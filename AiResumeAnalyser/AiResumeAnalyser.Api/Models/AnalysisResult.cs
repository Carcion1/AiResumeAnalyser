namespace AiResumeAnalyser.Api.Models
{
    // Represents output from API
    // ResumeAnalysisService sends the prompt to OpenAPI and receives JSON response
    // JSON is deserialized into an AnalysisResult object
    // Blazor frontend will read this object and display it to the user.
    // Acts as an answer received from the AI model (IN JSON FORMAT)
    public class AnalysisResult
    {
        public int MatchScore { get; set; }
        public List<string>? MissingKeywords { get; set; }
        public List<string>? Strengths { get; set; }
        public List<string>? Suggestions { get; set; }
    }
}
