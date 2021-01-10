using RestWithASPNET5.Model;
using System.Collections.Generic;

namespace RestWithASPNET5.Bussiness.Implementations
{
    public interface IBookBussiness
    {

        Book Create(Book book);

        Book FindByID(long id);

        List<Book> FindAll();
        
        Book Update(Book book);

        void Delete(long id);




    }


}
