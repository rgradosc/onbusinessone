namespace OnBusinessOne.Service.Models
{
    public class ResponseOK<T> : Response<T>
    {
        public int Id { get; set; }

        public T Data { get; set; }

        public string Result { get; set; }

        public string Message { get; set; }
    }
}
