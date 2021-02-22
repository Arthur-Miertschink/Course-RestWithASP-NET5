using RestWithASPNET5.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNET5.Bussiness.Implementations
{
    public interface IBookBussiness
    {

        BookVO Create(BookVO book);

        BookVO FindByID(long id);

        List<BookVO> FindAll();
        
        BookVO Update(BookVO book);

        void Delete(long id);




    }


}
