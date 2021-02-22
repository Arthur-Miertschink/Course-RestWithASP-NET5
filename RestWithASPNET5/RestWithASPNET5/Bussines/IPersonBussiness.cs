using RestWithASPNET5.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNET5.Bussiness.Implementations
{
    public interface IPersonBussiness
    {

        PersonVO Create(PersonVO person);

        PersonVO FindByID(long id);

        List<PersonVO> FindAll();
        
        PersonVO Update(PersonVO person);

        void Delete(long id);




    }


}
