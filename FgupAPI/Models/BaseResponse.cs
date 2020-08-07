namespace FgupAPI.Models
{
    public abstract class BaseResponse
    {
        public string ErrorMessage { get; set; } = string.Empty;
        public bool IsSuccess => string.IsNullOrWhiteSpace(ErrorMessage);
    }
}
