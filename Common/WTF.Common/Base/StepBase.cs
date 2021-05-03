using WTF.Core.Contracts;

namespace WTF.Core.Base
{
    public abstract class StepBase<TElement, TFactory, TDriver, TModel, TAppType, TViewType> : IStep
            where TElement : IObjectModel<TDriver>, new()
            where TFactory : IUIFactory<TDriver, TModel, TAppType, TViewType>, new()
    {
        protected IUIFactory<TDriver, TModel, TAppType, TViewType> Factory { get; private set; }

        protected TElement Context { get; set; }


        protected virtual void Initialize()
        {
            this.Factory = new TFactory();
        }

        protected virtual void WrapUp()
        {

        }
    }
}
