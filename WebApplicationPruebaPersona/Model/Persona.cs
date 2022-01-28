namespace WebApplicationPruebaPersona.Model
{
    public class Persona
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(int id,string? nombre, int edad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
        }
    }
}
