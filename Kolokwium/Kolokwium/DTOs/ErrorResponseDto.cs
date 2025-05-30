namespace Kolokwium.DTOs;

public class ErrorResponseDto
{
    public required int Status { get; set; }
    public required string Error { get; set; }
    public required string Message { get; set; }
    public required DateTime Timestamp { get; set; }
    public required string? Stacktrace { get; set; }   
}