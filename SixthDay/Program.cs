using System;
class Program
{
    public static void Main()
    {
        StockPrice s1 = new StockPrice
        {
            StockSymbol = "TCS",
            Price = 101
        };

        StockPrice s2 = s1;
        s2.StockSymbol = "REDMI";
        s2.Price = 290.0;

        Console.WriteLine($"Original Stock Price: {s1.StockSymbol} - {s1.Price}");
        Console.WriteLine($"Updated Stock Price: {s2.StockSymbol} - {s2.Price}");

        Trade trade = new Trade
        {
            TradeId = 101,
            StockSymbol = "AAPL",
            Quantity = 100
        };

        Trade trade2 = trade;
        trade2.TradeId = 202;
        trade2.StockSymbol = "TCS";
        trade2.Quantity = 203;

        Console.WriteLine($"Original Stock: {trade.TradeId} - {trade.StockSymbol} - {trade.Quantity}");
        Console.WriteLine($"Updated Stock: {trade.TradeId} - {trade.StockSymbol} - {trade.Quantity}");

    }
}