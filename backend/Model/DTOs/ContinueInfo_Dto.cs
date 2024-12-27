using System.Text.Json.Serialization;

namespace SearchEng.Model.DTOs
{

    /// <summary>
    /// Represents pagination details from the Wikipedia API response.
    /// </summary>
    public class ContinueInfo_Dto
    {
        /// <summary>
        /// The offset for the next set of search results.
        /// </summary>
        [JsonPropertyName("sroffset")]
        public int Sroffset { get; set; }

        /// <summary>
        /// The token to continue fetching additional results.
        /// </summary>
        [JsonPropertyName("continue")]
        public string ContinueToken { get; set; }
    }
}
