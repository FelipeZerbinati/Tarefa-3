using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tarefa3.Domain.Interfaces.Service;
using Tarefa3.Domain.Models;

namespace Tarefa3.Application.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> GetAll() 
        {
            List<Person> list = new List<Person>();
            var person = new Person()
            {
                Id = 0,
                Name = "Felipe",
                Cpf = "384.735.928-24"

            };            
            list.Add(person);
            var person2 = new Person()
            {
                Id = 1,
                Name = "Leonardo",
                Cpf = "465.342.678-05"

            };
            list.Add(person2);

            var person3 = new Person()
            {
                Id = 2,
                Name = "Paulo",
                Cpf = "456.123.678-29"
            };
            list.Add(person3);
            return list;
        }
    }
}
