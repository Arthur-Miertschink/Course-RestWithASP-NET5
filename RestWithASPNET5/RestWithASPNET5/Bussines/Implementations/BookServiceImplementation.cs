using RestWithASPNET5.Model;
using RestWithASPNET5.Model.Context;
using RestWithASPNET5.Repository;
using RestWithASPNETUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNET5.Bussiness.Implementations
{
    public class BookBussinessImplementation : IBookBussiness
    {
        private readonly IBookRepository _repository;

        public BookBussinessImplementation (IBookRepository repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
            
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }


        public Book FindByID(long id)
        {

            return _repository.FindByID(id);
        }

        public Book Update(Book book)
        {
            return _repository.Create(book);
        }

    }
}
