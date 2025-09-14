namespace OnBusinessOne.Service.Models
{
    public class Message<T>
    {
        public string Lang { get; set; }

        public T Value { get; set; }
    }
}
