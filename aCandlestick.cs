using System;

namespace Stock_Data
{
    // Represents a single candlestick object with stock data fields
    public class aCandlestick
    {
        // The date of the candlestick (i.e., the trading day)
        public DateTime Date { get; set; }

        // The opening price of the stock for the day
        public decimal Open { get; set; }

        // The highest price of the stock for the day
        public decimal High { get; set; }

        // The lowest price of the stock for the day
        public decimal Low { get; set; }

        // The closing price of the stock for the day
        public decimal Close { get; set; }

        // The trading volume of the stock for the day
        public decimal Volume { get; set; }

        // Constructor to initialize a candlestick with the given date, open, high, low, close, and volume values
        public aCandlestick(DateTime date, decimal open, decimal high, decimal low, decimal close, decimal volume)
        {
            Date = date;      // Sets the date for the candlestick
            Open = open;      // Sets the opening price
            High = high;      // Sets the highest price
            Low = low;        // Sets the lowest price
            Close = close;    // Sets the closing price
            Volume = volume;  // Sets the trading volume
        }
    }
}
