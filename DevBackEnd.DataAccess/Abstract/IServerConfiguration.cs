namespace DevBackEnd.DataAccess.Abstract
{
    public interface IServerConfiguration<T>
    {
        T ConnectionServer();
    }
}
