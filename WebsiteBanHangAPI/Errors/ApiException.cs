namespace WebsiteBanHangAPI.Errors
{
    public class ApiException
    {
        public ApiException(int statuscode, string message = null, string detail = null)
        {
            StatusCode = statuscode;
            Message = message;
            Detail = detail;
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }
    }
}
