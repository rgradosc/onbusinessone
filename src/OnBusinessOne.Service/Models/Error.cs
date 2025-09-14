namespace OnBusinessOne.Service.Models
{
    public class Error<T>
    {
        public int Code { get; set; }

        public Message<T> Message { get; set; }
    }
}
