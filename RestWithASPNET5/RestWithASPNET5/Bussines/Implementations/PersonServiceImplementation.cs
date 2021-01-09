using RestWithASPNET5.Model;
using RestWithASPNET5.Model.Context;
using RestWithASPNET5.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNET5.Bussiness.Implementations
{
    public class PersonBussinessImplementation : IPersonBussiness
    {
        private readonly IPersonRepository _repository;

        public PersonBussinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
            
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }


        public Person FindByID(long id)
        {

            return _repository.FindByID(id);
        }

        public Person Update(Person person)
        {
            return _repository.Create(person);
        }

    }
}
