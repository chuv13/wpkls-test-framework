namespace WTF.Core.Contracts
{

    public interface IObjectModel<T>
    {
        void InitializeDriver(T driver);
    }

    public interface IObjectModel
    {

    }

}
