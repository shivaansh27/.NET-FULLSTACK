struct PriceSnapshot
{
    public string StockSymbol;
    public double StockPrice;
}

abstract class Trade
{
    public int TradeId{get; set;}
    public string StockSymbol{get; set;}
    public int Quantity{get; set;}

    public abstract double CalculateTradeValue();

    public override string ToString()
    {
        return $"TradeId: {TradeId} StockSymbol: {StockSymbol} Quantity: {Quantity}";
    }
}

class EquityTrade : Trade
{
    public double? MarketPrice{get; set;}
    public override double CalculateTradeValue()
    {
        double price = MarketPrice??0;
        return Quantity * price;
    }
}

class TradeRepository<T> where T : Trade
{
    private List<T> trades = new List<T>();

    public static int TradeCounter = 0;
    public void AddTrade(T trade)
    {
        trades.Add(trade);
        TradeCounter++;
        TradeAnalytics.TotalTrades++;
    }

    public void DisplayTrade()
    {
        foreach(var trade in trades)
        {
            Console.WriteLine(trade.ToString());
        }
    }
}

static class TradeAnalytics
{
    public static int TotalTrades = 0;

    public static void DisplayAnalytics()
    {
        Console.WriteLine($"Total Trades Executive: {TotalTrades}");
    }

}

static class Extensions
{
    public static double CalculateBrokerage(this double amount, double brokerageRate)
    {
        return amount * brokerageRate;
    }

    public static double CalculateGst(this double amount, double gstRate)
    {
        return amount * gstRate;
    }
}

static class TradeProcessor
{
    public static void ProcessTrade(Trade trade)
    {
        switch (trade)
        {
            case EquityTrade:
                Console.WriteLine("Processing Equity Trade");
                break;

            default:
                Console.WriteLine("Unknown Trade Type");
                break;
        }
    }
}
