using System.Text.Json.Serialization;

namespace SearchEng.Model.DTOs
{

    /// <summary>
    /// Represents the query results and metadata from the Wikipedia API.
    /// </summary>
    public class QuerryResult_Dto
    {
        /// <summary>
        /// Contains metadata about the search, such as total hits and suggestions.
        /// </summary>
        [JsonPropertyName("searchinfo")]
        public SearchMetaData_Dto Searchinfo { get; set; }

        /// <summary>
        /// The list of search results.
        /// </summary>
        [JsonPropertyName("search")]
        public List<SearchResult_Dto> Search { get; set; }
    }
}
