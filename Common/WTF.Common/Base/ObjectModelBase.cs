using WTF.Core.Contracts;

namespace WTF.Core.Base
{
    public abstract class ObjectModelBase<TDriver, TElement> : IObjectModel<TDriver>
    {
        public TDriver Driver { get; protected set; }
        public abstract void InitializeDriver(TDriver driver);

        public abstract TElement FindElement(ITypeSafeEnum element);
    }
}
