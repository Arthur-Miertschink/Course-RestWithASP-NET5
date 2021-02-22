using RestWithASPNET5.Data.Converter.Implementation;
using RestWithASPNET5.Data.VO;
using RestWithASPNET5.Model;
using RestWithASPNET5.Repository;
using System.Collections.Generic;

namespace RestWithASPNET5.Bussiness.Implementations
{
    public class BookBussinessImplementation : IBookBussiness
    {
        private readonly IRepository<Book> _repository;

        private readonly BookConverter _converter;

        public BookBussinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
            
        }

        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }


        public BookVO FindByID(long id)
        {

            return _converter.Parse(_repository.FindByID(id));
        }

        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

    }
}
