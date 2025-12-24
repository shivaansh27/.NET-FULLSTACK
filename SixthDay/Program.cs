using System;

class Program
{
    public static void Main()
    {
        TradeRepository<EquityTrade> repository = new TradeRepository<EquityTrade>();

        EquityTrade t1 = new EquityTrade
        {
            TradeId = 1,
            StockSymbol = "AAPL",
            Quantity = 100,
            MarketPrice = 150.50
        };

        TradeProcessor.ProcessTrade(t1);

        double tradeValue1 = t1.CalculateTradeValue();
        double brokerage1 = tradeValue1.CalculateBrokerage(0.001);
        double gst1 = tradeValue1.CalculateGst(0.00018);

        Console.WriteLine($"Trade Value: {tradeValue1}");
        Console.WriteLine($"Brokerage: {brokerage1}");
        Console.WriteLine($"GST: {gst1}");
        Console.WriteLine(
            $"TradeId: {t1.TradeId}, Symbol: {t1.StockSymbol}, Qty: {t1.Quantity}"
        );
        Console.WriteLine();

        repository.AddTrade(t1);

        EquityTrade t2 = new EquityTrade
        {
            TradeId = 2,
            StockSymbol = "MSFT",
            Quantity = 50,
            MarketPrice = null
        };

        TradeProcessor.ProcessTrade(t2);

        double tradeValue2 = t2.CalculateTradeValue();
        double brokerage2 = tradeValue2.CalculateBrokerage(0.001);
        double gst2 = tradeValue2.CalculateGst(0.00018);

        Console.WriteLine($"Trade Value: {tradeValue2}");
        Console.WriteLine($"Brokerage: {brokerage2}");
        Console.WriteLine($"GST: {gst2}");
        Console.WriteLine(
            $"TradeId: {t2.TradeId}, Symbol: {t2.StockSymbol}, Qty: {t2.Quantity}"
        );
        Console.WriteLine();

        repository.AddTrade(t2);

        TradeAnalytics.DisplayAnalytics();
    }
}
