using System;
using WTF.Core.Contracts;

namespace WTF.Core.Base
{
    public abstract class UIFactoryBase<TDriver, TModel, TAppType, TViewType> : IUIFactory<TDriver, TModel, TAppType, TViewType>
    {
        public abstract TDriver GetDriver(TAppType appType);
        public abstract TModel Create(TViewType view, TDriver driver, TimeSpan timeOut);

    }
}
