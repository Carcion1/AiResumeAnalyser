namespace AiResumeAnalyser.Api.Models
{
    // record is lightweight, immutable data class in C#
    // Represents the input data that the API receives from the frontend
    // Serves as input to the ResumeAnalyzerService
    // Acts as a question sent to the AI model
    public record ResumeRequest(string ResumeText, string JobDescription);
}
