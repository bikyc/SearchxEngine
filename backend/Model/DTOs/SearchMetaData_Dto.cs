using System.Text.Json.Serialization;

namespace SearchEng.Model.DTOs
{
    
    /// <summary>
    /// Represents metadata about the search query.
    /// </summary>
    public class SearchMetaData_Dto
    {
        /// <summary>
        /// The total number of search results available.
        /// </summary>
        [JsonPropertyName("totalhits")]
        public int Totalhits { get; set; }

        /// <summary>
        /// A suggested alternative query, if applicable.
        /// </summary>
        [JsonPropertyName("suggestion")]
        public string Suggestion { get; set; }

        /// <summary>
        /// The snippet for the suggested query.
        /// </summary>
        [JsonPropertyName("suggestionsnippet")]
        public string Suggestionsnippet { get; set; }
    }
}
