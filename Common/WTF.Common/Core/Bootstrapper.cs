//using LightInject;
//using WTF.Common.Contracts;

//namespace WTF.Common.Core
//{
//    public abstract class BootstrapperBase : IBootstrapper
//    {
//        private ServiceContainer _container = null;

//        public ServiceContainer Container
//        {
//            get
//            {
//                if (_container == null)
//                    _container = new ServiceContainer();

//                return _container;
//            }
//        }

//        public abstract void RegisterInstances();

//        //protected void RegisterElement<T, U>(T type, U payload)
//        //{
//        //    this.Container.Register(typeof(T), typeof(U), new PerContainerLifetime());
//        //}
//    }
//}
