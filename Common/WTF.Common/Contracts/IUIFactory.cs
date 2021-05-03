using System;

namespace WTF.Core.Contracts
{
    public interface IUIFactory<TDriver, TModel, TAppType, TViewType>
    {
        TDriver GetDriver(TAppType appType);
        TModel Create(TViewType view, TDriver driver, TimeSpan timeOut);
    }
}
