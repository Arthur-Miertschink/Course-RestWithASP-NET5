using RestWithASPNET5.Data.VO;
using RestWithASPNET5.Model;
using System;

namespace RestWithASPNET5.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);


    }
}
