using System.Text.Json.Serialization;

public class Order
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName ("items")]
    public required List<OrderItem> Items {  get; set; }

}

public class OrderItem
{
    [JsonPropertyName("netCost")]
    public decimal NetCost { get; set; }
}