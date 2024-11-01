namespace Stock_Data
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button_loadData = new System.Windows.Forms.Button();
            this.chart_stockData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aCandlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.label_startDate = new System.Windows.Forms.Label();
            this.label_endDate = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_stockData = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appleButton = new System.Windows.Forms.Button();
            this.disneyButton = new System.Windows.Forms.Button();
            this.ibmButton = new System.Windows.Forms.Button();
            this.intelButton = new System.Windows.Forms.Button();
            this.payxButton = new System.Windows.Forms.Button();
            this.stockSelectButton = new System.Windows.Forms.Label();
            this.periodSelectButton = new System.Windows.Forms.Label();
            this.dayButton = new System.Windows.Forms.Button();
            this.chart_volumeData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weekButton = new System.Windows.Forms.Button();
            this.monthButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_volumeData)).BeginInit();
            this.SuspendLayout();
            // 
            // button_loadData
            // 
            this.button_loadData.Location = new System.Drawing.Point(1369, 572);
            this.button_loadData.Name = "button_loadData";
            this.button_loadData.Size = new System.Drawing.Size(229, 111);
            this.button_loadData.TabIndex = 1;
            this.button_loadData.Text = "Load Data";
            this.button_loadData.UseVisualStyleBackColor = true;
            this.button_loadData.Click += new System.EventHandler(this.button_loadData_Click);
            // 
            // chart_stockData
            // 
            this.chart_stockData.BackColor = System.Drawing.Color.DimGray;
            this.chart_stockData.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Blue;
            chartArea1.Name = "ChartArea1";
            this.chart_stockData.ChartAreas.Add(chartArea1);
            this.chart_stockData.DataSource = this.aCandlestickBindingSource;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart_stockData.Legends.Add(legend1);
            this.chart_stockData.Location = new System.Drawing.Point(0, 1);
            this.chart_stockData.Name = "chart_stockData";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.BackImageTransparentColor = System.Drawing.Color.Black;
            series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.BorderColor = System.Drawing.Color.Blue;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Color = System.Drawing.Color.White;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=0\\, 192\\, 0";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.LegendText = " ";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart_stockData.Series.Add(series1);
            this.chart_stockData.Size = new System.Drawing.Size(863, 400);
            this.chart_stockData.TabIndex = 2;
            this.chart_stockData.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "Stock Chart";
            this.chart_stockData.Titles.Add(title1);
            // 

            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(1077, 619);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker_startDate.TabIndex = 3;
            this.dateTimePicker_startDate.Value = new System.DateTime(2024, 9, 30, 0, 0, 0, 0);
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(1079, 657);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker_endDate.TabIndex = 4;
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Location = new System.Drawing.Point(990, 620);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(83, 20);
            this.label_startDate.TabIndex = 5;
            this.label_startDate.Text = "Start Date";
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Location = new System.Drawing.Point(992, 663);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(77, 20);
            this.label_endDate.TabIndex = 6;
            this.label_endDate.Text = "End Date";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView_stockData
            // 
            this.dataGridView_stockData.AllowUserToOrderColumns = true;
            this.dataGridView_stockData.AutoGenerateColumns = false;
            this.dataGridView_stockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stockData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn});
            this.dataGridView_stockData.DataSource = this.aCandlestickBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_stockData.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_stockData.Location = new System.Drawing.Point(2, 413);
            this.dataGridView_stockData.Name = "dataGridView_stockData";
            this.dataGridView_stockData.RowHeadersWidth = 62;
            this.dataGridView_stockData.RowTemplate.Height = 28;
            this.dataGridView_stockData.Size = new System.Drawing.Size(970, 288);
            this.dataGridView_stockData.TabIndex = 7;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateDataGridViewTextBoxColumn.Width = 115;
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "Open";
            dataGridViewCellStyle1.Format = "N1";
            this.openDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.openDataGridViewTextBoxColumn.HeaderText = "Open";
            this.openDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.Width = 90;
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "High";
            dataGridViewCellStyle2.Format = "N1";
            this.highDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.highDataGridViewTextBoxColumn.HeaderText = "High";
            this.highDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            this.highDataGridViewTextBoxColumn.Width = 90;
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "Low";
            dataGridViewCellStyle3.Format = "N1";
            this.lowDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.lowDataGridViewTextBoxColumn.HeaderText = "Low";
            this.lowDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            this.lowDataGridViewTextBoxColumn.Width = 90;
            // 
            // closeDataGridViewTextBoxColumn
            // 
            this.closeDataGridViewTextBoxColumn.DataPropertyName = "Close";
            dataGridViewCellStyle4.Format = "N1";
            this.closeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.closeDataGridViewTextBoxColumn.HeaderText = "Close";
            this.closeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            this.closeDataGridViewTextBoxColumn.Width = 90;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.Width = 90;
            // 
            // appleButton
            // 
            this.appleButton.Location = new System.Drawing.Point(996, 448);
            this.appleButton.Name = "appleButton";
            this.appleButton.Size = new System.Drawing.Size(94, 64);
            this.appleButton.TabIndex = 8;
            this.appleButton.Text = "Apple";
            this.appleButton.UseVisualStyleBackColor = true;
            this.appleButton.Click += new System.EventHandler(this.appleButton_Click);
            // 
            // disneyButton
            // 
            this.disneyButton.Location = new System.Drawing.Point(1105, 448);
            this.disneyButton.Name = "disneyButton";
            this.disneyButton.Size = new System.Drawing.Size(94, 64);
            this.disneyButton.TabIndex = 9;
            this.disneyButton.Text = "Disney";
            this.disneyButton.UseVisualStyleBackColor = true;
            this.disneyButton.Click += new System.EventHandler(this.disneyButton_Click);
            // 
            // ibmButton
            // 
            this.ibmButton.Location = new System.Drawing.Point(1214, 448);
            this.ibmButton.Name = "ibmButton";
            this.ibmButton.Size = new System.Drawing.Size(94, 64);
            this.ibmButton.TabIndex = 10;
            this.ibmButton.Text = "IBM";
            this.ibmButton.UseVisualStyleBackColor = true;
            this.ibmButton.Click += new System.EventHandler(this.ibmButton_Click);
            // 
            // intelButton
            // 
            this.intelButton.Location = new System.Drawing.Point(1325, 448);
            this.intelButton.Name = "intelButton";
            this.intelButton.Size = new System.Drawing.Size(94, 64);
            this.intelButton.TabIndex = 11;
            this.intelButton.Text = "Intel";
            this.intelButton.UseVisualStyleBackColor = true;
            this.intelButton.Click += new System.EventHandler(this.intelButton_Click);
            // 
            // payxButton
            // 
            this.payxButton.Location = new System.Drawing.Point(1437, 448);
            this.payxButton.Name = "payxButton";
            this.payxButton.Size = new System.Drawing.Size(94, 64);
            this.payxButton.TabIndex = 12;
            this.payxButton.Text = "PayX";
            this.payxButton.UseVisualStyleBackColor = true;
            this.payxButton.Click += new System.EventHandler(this.payxButton_Click);
            // 
            // stockSelectButton
            // 
            this.stockSelectButton.AutoSize = true;
            this.stockSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stockSelectButton.Location = new System.Drawing.Point(991, 418);
            this.stockSelectButton.Name = "stockSelectButton";
            this.stockSelectButton.Size = new System.Drawing.Size(155, 25);
            this.stockSelectButton.TabIndex = 13;
            this.stockSelectButton.Text = "1. Select a stock";
            // 
            // periodSelectButton
            // 
            this.periodSelectButton.AutoSize = true;
            this.periodSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.periodSelectButton.Location = new System.Drawing.Point(991, 524);
            this.periodSelectButton.Name = "periodSelectButton";
            this.periodSelectButton.Size = new System.Drawing.Size(306, 25);
            this.periodSelectButton.TabIndex = 14;
            this.periodSelectButton.Text = "2. Select a period for each candle.";
            // 
            // dayButton
            // 
            this.dayButton.Location = new System.Drawing.Point(996, 552);
            this.dayButton.Name = "dayButton";
            this.dayButton.Size = new System.Drawing.Size(94, 48);
            this.dayButton.TabIndex = 15;
            this.dayButton.Text = "Day";
            this.dayButton.UseVisualStyleBackColor = true;
            this.dayButton.Click += new System.EventHandler(this.dayButton_Click);
            // 
            // chart_volumeData
            // 
            this.chart_volumeData.BackColor = System.Drawing.Color.DimGray;
            this.chart_volumeData.BackSecondaryColor = System.Drawing.Color.White;
            this.chart_volumeData.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Silver;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea2.BackSecondaryColor = System.Drawing.Color.SpringGreen;
            chartArea2.Name = "ChartArea1";
            this.chart_volumeData.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart_volumeData.Legends.Add(legend2);
            this.chart_volumeData.Location = new System.Drawing.Point(859, 1);
            this.chart_volumeData.Name = "chart_volumeData";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_volumeData.Series.Add(series2);
            this.chart_volumeData.Size = new System.Drawing.Size(774, 400);
            this.chart_volumeData.TabIndex = 16;
            this.chart_volumeData.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title2.Name = "Title1";
            title2.Text = "Volume";
            this.chart_volumeData.Titles.Add(title2);
            // 
            // weekButton
            // 
            this.weekButton.Location = new System.Drawing.Point(1105, 552);
            this.weekButton.Name = "weekButton";
            this.weekButton.Size = new System.Drawing.Size(94, 48);
            this.weekButton.TabIndex = 17;
            this.weekButton.Text = "Week";
            this.weekButton.UseVisualStyleBackColor = true;
            this.weekButton.Click += new System.EventHandler(this.weekButton_Click);
            // 
            // monthButton
            // 
            this.monthButton.Location = new System.Drawing.Point(1214, 552);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(94, 48);
            this.monthButton.TabIndex = 18;
            this.monthButton.Text = "Month";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.monthButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 709);
            this.Controls.Add(this.monthButton);
            this.Controls.Add(this.weekButton);
            this.Controls.Add(this.chart_volumeData);
            this.Controls.Add(this.dayButton);
            this.Controls.Add(this.periodSelectButton);
            this.Controls.Add(this.stockSelectButton);
            this.Controls.Add(this.payxButton);
            this.Controls.Add(this.intelButton);
            this.Controls.Add(this.ibmButton);
            this.Controls.Add(this.disneyButton);
            this.Controls.Add(this.appleButton);
            this.Controls.Add(this.dataGridView_stockData);
            this.Controls.Add(this.label_endDate);
            this.Controls.Add(this.label_startDate);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.chart_stockData);
            this.Controls.Add(this.button_loadData);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Stock Data Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.chart_stockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_volumeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button button_loadData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stockData;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView_stockData;
        private System.Windows.Forms.BindingSource aCandlestickBindingSource;
        private System.Windows.Forms.Button appleButton;
        private System.Windows.Forms.Button disneyButton;
        private System.Windows.Forms.Button ibmButton;
        private System.Windows.Forms.Button intelButton;
        private System.Windows.Forms.Button payxButton;
        private System.Windows.Forms.Label stockSelectButton;
        private System.Windows.Forms.Label periodSelectButton;
        private System.Windows.Forms.Button dayButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_volumeData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button weekButton;
        private System.Windows.Forms.Button monthButton;
    }
}

