using Microsoft.AspNetCore.Mvc;
using WebApplicationPruebaPersona.Model;
using WebApplicationPruebaPersona.Repository;

namespace WebApplicationPruebaPersona.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {

        private PersonaRepository PersonaRepositorio;

        public PersonaController(PersonaRepository personaRepositorio)
        {
            PersonaRepositorio = personaRepositorio;
        }

        [HttpPost]
        public void CreatePersona(Persona persona)
        {
            PersonaRepositorio.Add(persona);
        }

        [HttpGet]
        [Route("api/[controller]")]
        public List<Persona> GetPersonas()
        {
           return PersonaRepositorio.GetAll();
        }

        [HttpGet]
        [Route("/{id}")]
        public Persona GetPersona(int id)
        {
            return PersonaRepositorio.FindId(id);
        }

        [HttpDelete]
        [Route("/{id}")]
        public void DeletePersona(int id)
        {            
            PersonaRepositorio.Delete(id);
        }

        [HttpPut]
        public void UpdateEdadPersona(int id, int edad)
        {
            PersonaRepositorio.UpdateEdad(id, edad);  
        }


    }
}