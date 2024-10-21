using System.Text.Json.Serialization;

namespace Stocks.Domain.Models
{
    public class StockDetails
    {
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        [JsonPropertyName("changesPercentage")]
        public float? ChangesPercentage { get; set; }

        [JsonPropertyName("change")]
        public float? Change { get; set; }

        [JsonPropertyName("dayLow")]
        public decimal? DayLow { get; set; }

        [JsonPropertyName("dayHigh")]
        public decimal? DayHigh { get; set; }

        [JsonPropertyName("yearHigh")]
        public decimal? YearHigh { get; set; }

        [JsonPropertyName("yearLow")]
        public decimal? YearLow { get; set; }

        [JsonPropertyName("marketCap")]
        public long? MarketCap { get; set; }

        [JsonPropertyName("priceAvg50")]
        public decimal? PriceAvg50 { get; set; }

        [JsonPropertyName("priceAvg200")]
        public decimal? PriceAvg200 { get; set; }

        [JsonPropertyName("exchange")]
        public string? Exchange { get; set; }

        [JsonPropertyName("volume")]
        public int? Volume { get; set; }

        [JsonPropertyName("avgVolume")]
        public int? AvgVolume { get; set; }

        [JsonPropertyName("open")]
        public float? Open { get; set; }

        [JsonPropertyName("previousClose")]
        public decimal PreviousClose { get; set; }

        [JsonPropertyName("eps")]
        public float? Eps { get; set; }

        [JsonPropertyName("pe")]
        public float? Pe { get; set; }

        [JsonPropertyName("earningsAnnouncement")]
        public string? EarningsAnnouncement { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public long? SharesOutstanding { get; set; }

        [JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }
    }
}
