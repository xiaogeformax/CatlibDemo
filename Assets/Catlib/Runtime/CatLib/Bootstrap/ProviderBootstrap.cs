using CatLib.Facade;

namespace CatLib
{
    /// <summary>
    /// 默认提供者引导
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal class ProviderBootstrap : IBootstrap
    {
        /// <summary>
        /// 引导程序接口
        /// </summary>
        public void Bootstrap()
        {
            App.On(ApplicationEvents.OnStartCompleted, (payload) =>
            {
               
                if (Router.Instance != null)
                {
                    Router.Instance.Dispatch("bootstrap://config");
                    Router.Instance.Dispatch("bootstrap://start");
                }
            });
        }
    }
}