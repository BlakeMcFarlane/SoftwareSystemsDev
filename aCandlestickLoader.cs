using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Stock_Data
{
    // A candlestick loader class which holds one functions called 'LoadFromCsv'
    public static class aCandlestickLoader
    {
        // This function returns a list of candlesticks from a .csv file
        public static List<aCandlestick> LoadFromCsv(string filePath)
        {
            // Initialize Candlestick list
            List<aCandlestick> candlesticks = new List<aCandlestick>();


            using (var reader = new StreamReader(filePath))
            {            
                string line = reader.ReadLine();                // Skip the header line
                int lineNumber = 1;                             // Line counter variable

                // Stream iterates through .csv file, creating a candlestick each iteration
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();                           // Storing a single line a string
                    lineNumber++;                                       // Increment line number to read next line

                    if (string.IsNullOrWhiteSpace(line)) continue;      // Skip empty line

                    var values = line.Split(',');                       // Split each line up by comma (',')


                    // Parse values from CSV line 
                    DateTime date = DateTime.ParseExact(values[0].Trim('"'), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    decimal open = decimal.Parse(values[1], CultureInfo.InvariantCulture);
                    decimal high = decimal.Parse(values[2], CultureInfo.InvariantCulture);
                    decimal low = decimal.Parse(values[3], CultureInfo.InvariantCulture);
                    decimal close = decimal.Parse(values[4], CultureInfo.InvariantCulture);
                    decimal volume = decimal.Parse(values[5], CultureInfo.InvariantCulture);

                    // Create a new aCandlestick object
                    aCandlestick candlestick = new aCandlestick(date, open, high, low, close, volume);

                    // Add candlestick to list of candlesticks
                    candlesticks.Add(candlestick);
                }
            }

            return candlesticks;                                // Return list of candlesticks
        }

    }
}
