namespace RazorIssue8502_api.Models;

class LineItemWithIndex
{
    public int Index;
    public string Sku;
    public int ProductId;
    public int Id;
    public int Quantity;
    public int Price;
    public int Discount;
    public string Description;

    public LineItemWithIndex(int index, int discount)
    {
        Index = index;
        Sku = $"sku{index}";
        ProductId = index + 1;
        Id = index + 1;
        Quantity = index;
        Price = discount + 20;
        Discount = discount;
        Description = $"My product {index}";
    }
}
