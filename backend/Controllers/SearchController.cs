using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SearchEng.Model.DTOs;

[ApiController]
[Route("api/[controller]")]
public class SearchController : ControllerBase
{
    [HttpGet("search")]
    public async Task<IActionResult> Search([FromQuery] string query)
    {
        using (HttpClient client = new HttpClient())
        {
            string url = $"https://en.wikipedia.org/w/api.php?action=query&list=search&srsearch={Uri.EscapeDataString(query)}&format=json&srlimit=500";

            try
            {
                var response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return StatusCode((int)response.StatusCode, "Failed to fetch data from Wikipedia.");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Wikipedia API Response: " + responseContent); // Log the response for debugging

                // Deserialize the Wikipedia API response
                var wikipediaResponse = JsonSerializer.Deserialize<WikiResponse_Dto>(
                    responseContent,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );

                if (wikipediaResponse?.Query?.Search == null || !wikipediaResponse.Query.Search.Any())
                {
                    return NotFound(new { message = "No results found for the given query." });
                }

                // Prepare a simplified response for the frontend
                var simplifiedResults = wikipediaResponse.Query.Search.Select(result => new
                {
                    Title = result.Title,
                    Snippet = result.Snippet,
                    PageUrl = $"https://en.wikipedia.org/?curid={result.Pageid}",
                    Timestamp = result.Timestamp
                }).ToList();

                return Ok(new
                {
                    TotalHits = wikipediaResponse.Query.Searchinfo.Totalhits,
                    Suggestion = wikipediaResponse.Query.Searchinfo.Suggestion,
                    Results = simplifiedResults
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}