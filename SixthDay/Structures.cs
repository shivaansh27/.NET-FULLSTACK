struct StockPrice
{
    public string StockSymbol;
    public double Price;
}

class Trade
{
    public int TradeId{get; set;}
    public string StockSymbol{get; set;}
    public int Quantity{get; set;}
}
