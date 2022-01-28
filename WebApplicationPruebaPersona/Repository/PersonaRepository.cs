using WebApplicationPruebaPersona.Model;

namespace WebApplicationPruebaPersona.Repository
{
    public class PersonaRepository
    {

        private List<Persona> Personas = new List<Persona>();

        public List<Persona> GetAll()
        {
            return Personas;
        }

        public Persona FindId(int id)
        {
            return Personas.Find(p => p.Id == id);
        }

        public void Add(Persona persona)
        {
            Personas.Add(persona);
        }

        public void Delete(int id)
        {
            Persona p = FindId(id);
            Personas.Remove(p);
        }

        public void UpdateEdad(int id, int edad)
        {
            Persona p = FindId(id);
            p.Edad = edad;
        }
    }

}
