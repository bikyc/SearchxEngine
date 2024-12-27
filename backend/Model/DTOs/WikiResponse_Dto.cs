using System.Text.Json.Serialization;

namespace SearchEng.Model.DTOs
{
 
    /// <summary>
    /// Represents the root response from the Wikipedia API.
    /// </summary>
    public class WikiResponse_Dto
    {
        /// <summary>
        /// Indicates whether the batch query was completed.
        /// </summary>
        [JsonPropertyName("batchcomplete")]
        public string Batchcomplete { get; set; }

        /// <summary>
        /// Contains pagination details for the next set of results.
        /// </summary>
        [JsonPropertyName("continue")]
        public ContinueInfo_Dto Continue { get; set; }

        /// <summary>
        /// Contains the query results and metadata.
        /// </summary>
        [JsonPropertyName("query")]
        public QuerryResult_Dto Query { get; set; }
    }
}
