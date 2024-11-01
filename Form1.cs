using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Stock_Data
{
    /// <summary>
    /// Main Form Loader class which inherits from Form. 
    /// </summary>
    public partial class Form1 : Form
    {
        // Initializing variables
        private List<aCandlestick> candlesticks;                    // List to store candlesticks
        private string selectedStock = "AAPL";                      // Default stock
        private string selectedPeriod = "Day";                      // Default period
        private DateTime startDate = new DateTime(2024, 8, 12);     // Default chart start date
        private DateTime endDate = new DateTime(2024, 9, 12);       // Default chart end date
        private bool datePickersInitialized = false;                // Flag for first time run

        public Form1()
        {
            InitializeComponent();

            // Subscribe to the form Load event
            this.Load += Form1_Load;

            // Subscribe to the DateTimePicker ValueChanged events
            dateTimePicker_startDate.ValueChanged += DateTimePicker_ValueChanged;
            dateTimePicker_endDate.ValueChanged += DateTimePicker_ValueChanged;
        }

        /// <summary>
        /// Event handler for Form1 load. Sets default selections and loads the initial data.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set default selections
            appleButton.BackColor = Color.LightBlue;
            dayButton.BackColor = Color.LightBlue;

            // Specify the path to your CSV file
            string filePath = Path.Combine(Application.StartupPath, "Stock Data", "AAPL-Day.csv");
            
            LoadCandlestickData(filePath);
        }

        /// <summary>
        /// Event handler for the Load Data button click. Loads data based on selected stock and period.
        /// </summary>
        private void button_loadData_Click(object sender, EventArgs e)
        {
            string fileName = $"{selectedStock}-{selectedPeriod}.csv";
            string filePath = Path.Combine(Application.StartupPath, "Stock Data", fileName);

            LoadCandlestickData(filePath);
        }

        /// <summary>
        /// Loads candlestick data from a specified CSV file and binds it to the UI components.
        /// </summary>
        private void LoadCandlestickData(string filePath)
        {
            // Checking if .csv file was found sucessfully
            if (!File.Exists(filePath))
            {
                MessageBox.Show("CSV file not found at path: " + filePath);
                return;
            }

            // load the candlestick data in list of candlesticks
            candlesticks = aCandlestickLoader.LoadFromCsv(filePath);

            // data could not be read from file
            if (candlesticks == null || !candlesticks.Any())
            {
                MessageBox.Show("No data loaded.");
                return;
            }

            // Bind the data to the DataGridView
            dataGridView_stockData.DataSource = candlesticks;

            // Set up the DateTimePickers only if they haven't been initialized yet
            if (!datePickersInitialized)
            {
                SetupDateTimePickers();
                datePickersInitialized = true;              // Flag to avoid re-initializing on subsequent loads
            }

            // Update the Chart with initial data
            FilterCandlesticks();                           // Use the class-level startDate and endDate for filtering
        }

        /// <summary>
        /// Configures the DateTimePickers with minimum and maximum dates based on the loaded data.
        /// Sets initial values to the class-level startDate and endDate.
        /// </summary>
        private void SetupDateTimePickers()
        {
            DateTime minDate = candlesticks.Min(c => c.Date);
            DateTime maxDate = candlesticks.Max(c => c.Date);

            dateTimePicker_startDate.MinDate = minDate;
            dateTimePicker_startDate.MaxDate = maxDate;
            dateTimePicker_endDate.MinDate = minDate;
            dateTimePicker_endDate.MaxDate = maxDate;

            dateTimePicker_startDate.Value = startDate;
            dateTimePicker_endDate.Value = endDate;
        }

        /// <summary>
        /// Event handler for changes in DateTimePicker values. Calls FilterCandlesticks to update the displayed data.
        /// </summary>
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FilterCandlesticks();
        }

        /// <summary>
        /// Filters the candlestick data based on the selected date range in DateTimePickers.
        /// Updates both the DataGridView and the Chart to display the filtered data.
        /// </summary>
        private void FilterCandlesticks()
        {
            DateTime startDate = dateTimePicker_startDate.Value.Date;
            DateTime endDate = dateTimePicker_endDate.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be after end date.");
                return;
            }

            var filteredCandlesticks = candlesticks
                .Where(c => c.Date >= startDate && c.Date <= endDate)
                .ToList();

            dataGridView_stockData.DataSource = null;
            dataGridView_stockData.DataSource = filteredCandlesticks;

            UpdateChart(filteredCandlesticks);
        }

        /// <summary>
        /// Updates the stock and volume charts with filtered candlestick data.
        /// Configures appearance, axes, and aligns the two charts.
        /// </summary>
        private void UpdateChart(List<aCandlestick> filteredCandlesticks)
        {
            // Clear existing series from both charts
            chart_stockData.Series.Clear();
            chart_volumeData.Series.Clear();

            // ========================
            // Configure Stock Data Chart (Candlesticks)
            // ========================

            // Create a new series for candlesticks
            Series stockSeries = new Series("Candlesticks");
            stockSeries.ChartType = SeriesChartType.Candlestick;
            stockSeries.XValueType = ChartValueType.DateTime;

            // Set candlestick appearance
            stockSeries["OpenCloseStyle"] = "Triangle";
            stockSeries["ShowOpenClose"] = "Both";
            stockSeries["PointWidth"] = "0.8";
            stockSeries["PriceUpColor"] = "Green";
            stockSeries["PriceDownColor"] = "Red";

            // Add data points to the candlestick series
            foreach (var candle in filteredCandlesticks)
            {
                int pointIndex = stockSeries.Points.AddXY(candle.Date, candle.High);
                DataPoint point = stockSeries.Points[pointIndex];

                point.XValue = candle.Date.ToOADate();
                point.YValues = new double[] {
                    (double)candle.High,
                    (double)candle.Low,
                    (double)candle.Open,
                    (double)candle.Close
                };
            }

            // Add the series to the stock chart
            chart_stockData.Series.Add(stockSeries);

            // Configure X-axis of the stock chart
            chart_stockData.ChartAreas[0].AxisX.LabelStyle.Format = "M/d/yy";
            chart_stockData.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart_stockData.ChartAreas[0].AxisX.MajorGrid.Enabled = false;


            // Calculate Y-axis range for stock chart
            decimal minY = filteredCandlesticks.Min(c => c.Low);
            decimal maxY = filteredCandlesticks.Max(c => c.High);

            // Ensure that minY and maxY are not the same
            if (minY == maxY)
            {
                // Adjust maxY to create a range
                maxY = minY + 1;
            }

            decimal yAxisPadding = (maxY - minY) * 0.05m; // 5% padding
            decimal adjustedMinY = minY - yAxisPadding;
            decimal adjustedMaxY = maxY + yAxisPadding;

            // Set Y-axis properties for stock chart
            chart_stockData.ChartAreas[0].AxisY.Minimum = (double)adjustedMinY;
            chart_stockData.ChartAreas[0].AxisY.Maximum = (double)adjustedMaxY;
            chart_stockData.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chart_stockData.ChartAreas[0].AxisY.LabelStyle.Format = "F0";

            // ========================
            // Configure Volume Data Chart
            // ========================

            // Define a scale factor to display volume in millions
            const decimal volumeScaleFactor = 1_000_000m;

            // Create a new series for volume data
            Series volumeSeries = new Series("Volume");
            volumeSeries.ChartType = SeriesChartType.Column; // Use Column chart for volume
            volumeSeries.XValueType = ChartValueType.DateTime;

            // Add data points to the volume series
            foreach (var candle in filteredCandlesticks)
            {
                decimal scaledVolume = candle.Volume / volumeScaleFactor;

                int pointIndex = volumeSeries.Points.AddXY(candle.Date, scaledVolume);
                DataPoint point = volumeSeries.Points[pointIndex];

                point.XValue = candle.Date.ToOADate();
                point.YValues = new double[] { (double)scaledVolume };
            }

            // Add the series to the volume chart
            chart_volumeData.Series.Add(volumeSeries);

            // Configure X-axis of the volume chart
            chart_volumeData.ChartAreas[0].AxisX.LabelStyle.Format = "M/d/yy";
            chart_volumeData.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart_volumeData.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Synchronize the X-axis range with the stock chart
            DateTime minDate = filteredCandlesticks.Min(c => c.Date);
            DateTime maxDate = filteredCandlesticks.Max(c => c.Date);

            // Fixes bug that arised when user selected invalid period interval
            if (selectedPeriod == "Month" && (maxDate - minDate).TotalDays <= 30)
            {
                maxDate = minDate.AddDays(30);
            }
            else if ((selectedPeriod == "Week" && (maxDate - minDate).TotalDays <= 7))
            {
                maxDate = minDate.AddDays(7);
            }
            else if ((selectedPeriod == "Day" && (maxDate - minDate).TotalDays <= 1))
            {
                maxDate = minDate.AddDays(1);
            }

            chart_stockData.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            chart_stockData.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

            chart_volumeData.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            chart_volumeData.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

            // ========================
            // Dynamically Adjust X-Axis Label Interval
            // ========================

            // Calculate a suitable interval based on the number of data points
            chart_stockData.ChartAreas[0].AxisX.Interval = 0;
            chart_volumeData.ChartAreas[0].AxisX.Interval = 0;

            // Set the interval type for date labels
            chart_stockData.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            chart_volumeData.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

            // Adjust Y-axis for volume chart
            decimal maxVolume = filteredCandlesticks.Max(c => c.Volume) / volumeScaleFactor * 1.05m; // Add 5% padding
            chart_volumeData.ChartAreas[0].AxisY.Minimum = 0; // Start from zero
            chart_volumeData.ChartAreas[0].AxisY.Maximum = (double)maxVolume;


            // Format Y-axis labels to show no decimal places
            chart_volumeData.ChartAreas[0].AxisY.LabelStyle.Format = "F0";

            // ========================
            // Align the Two Charts
            // ========================

            // Align the charts' positions (if they are stacked vertically)
            AlignChartAreas(chart_stockData, chart_volumeData);

            // Recalculate axes scale for both charts
            chart_stockData.ChartAreas[0].RecalculateAxesScale();
            chart_volumeData.ChartAreas[0].RecalculateAxesScale();
        }

        /// <summary>
        /// Aligns the chart areas of two charts by setting their positions and axes ranges.
        /// Ensures synchronized visual alignment of both charts when displayed together.
        /// </summary>
        private void AlignChartAreas(Chart chart1, Chart chart2)
        {
            // Align chart areas' positions
            chart2.ChartAreas[0].Position = chart1.ChartAreas[0].Position;
            chart2.ChartAreas[0].InnerPlotPosition = chart1.ChartAreas[0].InnerPlotPosition;

            // Align axes
            chart2.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Minimum;
            chart2.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.Maximum;
            chart2.ChartAreas[0].AxisX.Interval = chart1.ChartAreas[0].AxisX.Interval;
        }

        /// <summary>
        /// Sets selected stock to Disney (DIS) and updates button colors to reflect selection.
        /// </summary>
        private void disneyButton_Click(object sender, EventArgs e)
        {
            disneyButton.BackColor = Color.LightBlue;               // Selected button to blue

            appleButton.BackColor = Color.White;
            ibmButton.BackColor = Color.White;
            intelButton.BackColor = Color.White;
            payxButton.BackColor = Color.White;

            selectedStock = "DIS";
        }

        /// <summary>
        /// Sets selected stock to Apple (AAPL) and updates button colors to reflect selection.
        /// </summary>
        private void appleButton_Click(object sender, EventArgs e)
        {
            appleButton.BackColor = Color.LightBlue;                // Selected button to blue

            disneyButton.BackColor = Color.White;
            ibmButton.BackColor = Color.White;
            intelButton.BackColor = Color.White;
            payxButton.BackColor = Color.White;

            selectedStock = "AAPL";
        }

        /// <summary>
        /// Sets selected stock to IBM (IBM) and updates button colors to reflect selection.
        /// </summary>
        private void ibmButton_Click(object sender, EventArgs e)
        {
            ibmButton.BackColor = Color.LightBlue;                  // Selected button to blue

            appleButton.BackColor = Color.White;
            disneyButton.BackColor = Color.White;
            intelButton.BackColor = Color.White;
            payxButton.BackColor = Color.White;

            selectedStock = "IBM";
        }

        /// <summary>
        /// Sets selected stock to Intel (INTL) and updates button colors to reflect selection.
        /// </summary>
        private void intelButton_Click(object sender, EventArgs e)
        {
            intelButton.BackColor = Color.LightBlue;            // Selected button to blue

            appleButton.BackColor = Color.White;
            ibmButton.BackColor = Color.White;
            disneyButton.BackColor = Color.White;
            payxButton.BackColor = Color.White;

            selectedStock = "INTC";
        }

        /// <summary>
        /// Sets selected stock to Paychex (PayX) and updates button colors to reflect selection.
        /// </summary>
        private void payxButton_Click(object sender, EventArgs e)
        {
            payxButton.BackColor = Color.LightBlue;             // Selected button to blue

            appleButton.BackColor = Color.White;
            ibmButton.BackColor = Color.White;
            intelButton.BackColor = Color.White;
            disneyButton.BackColor = Color.White;

            selectedStock = "DIS";
        }

        /// <summary>
        /// Sets selected period to day and updates the button colors to reflect section
        /// </summary>
        private void dayButton_Click(object sender, EventArgs e)
        {
            dayButton.BackColor = Color.LightBlue;      // Selected button to blue
            weekButton.BackColor = Color.White;
            monthButton.BackColor = Color.White;

            selectedPeriod = "Day";                     // Set the selected period
        }

        /// <summary>
        /// Sets selected period to week and updates the button colors to reflect section
        /// </summary>
        private void weekButton_Click(object sender, EventArgs e)
        {
            weekButton.BackColor = Color.LightBlue;     // Selected button to blue
            dayButton.BackColor = Color.White;
            monthButton.BackColor = Color.White;

            selectedPeriod = "Week";                    // Set the selected period
        }

        /// <summary>
        /// Sets selected period to month and updates the button colors to reflect section
        /// </summary>
        private void monthButton_Click(object sender, EventArgs e)
        {
            monthButton.BackColor = Color.LightBlue;    // Selected button to blue
            dayButton.BackColor = Color.White;
            weekButton.BackColor = Color.White;

            selectedPeriod = "Month";                   // Set the selected period
        }
    }
}

