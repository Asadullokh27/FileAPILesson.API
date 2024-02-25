using FileAPILesson.Domain.Entities.DTOs;
using FileAPILesson.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAPILesson.Application.Services
{
    public interface IPersonService
    {

        public Task<PersonDTO> CreateNewPerson(PersonDTO newPerson);
        public Task<Person> UpdatePerson(PersonDTO newPerson, int id);
        public Task<bool> DeletePerson(int id);
        public Task<Person> GetById(int id);
        public Task<IEnumerable<Person>> GetAll();

    }
}
