using RestWithASPNET5.Data.VO;

namespace RestWithASPNET5.Bussines
{
    public interface ILoginBussiness
    {
        TokenVO ValidateCredentials(UserVO user);

    }
}
