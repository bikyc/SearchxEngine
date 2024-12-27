using System.Text.Json.Serialization;
namespace SearchEng.Model.DTOs
{

    /// <summary>
    /// Represents an individual search result from the Wikipedia API.
    /// </summary>
    public class SearchResult_Dto
    {
        /// <summary>
        /// The namespace of the search result.
        /// </summary>
        [JsonPropertyName("ns")]
        public int Ns { get; set; }

        /// <summary>
        /// The title of the search result.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// The page ID of the search result.
        /// </summary>
        [JsonPropertyName("pageid")]
        public int Pageid { get; set; }

        /// <summary>
        /// The size of the page content, in bytes.
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }

        /// <summary>
        /// The word count of the page content.
        /// </summary>
        [JsonPropertyName("wordcount")]
        public int Wordcount { get; set; }

        /// <summary>
        /// A snippet of the page content matching the search query.
        /// </summary>
        [JsonPropertyName("snippet")]
        public string Snippet { get; set; }

        /// <summary>
        /// The timestamp of the last edit to the page.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}