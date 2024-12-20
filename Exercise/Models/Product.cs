using System.Text.Json.Serialization;

public class Product
{
    [JsonPropertyName("product_id")]
    public int Id { get; set; }

    [JsonPropertyName("product_name")]
    public required string Name { get; set; }

    [JsonPropertyName("cost")]
    public decimal Price { get; set; }
}