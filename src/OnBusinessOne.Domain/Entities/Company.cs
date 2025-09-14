namespace OnBusinessOne.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string DataBase { get; set; }

        public string Usuario { get; set; }

        public string Clave { get; set; }

        public string Observacion { get; set; }

        public bool InSession { get; set; }

        public string SessionId { get; set; }

        public string RouteId { get; set; }
    }
}
