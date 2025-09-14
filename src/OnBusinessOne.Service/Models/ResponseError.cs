namespace OnBusinessOne.Service.Models
{
    public class ResponseError<T>
    {
        public Error<T> Error { get; set; }
    }
}
