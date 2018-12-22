namespace CatLib
{
    /// <summary>
    /// 框架默认的引导程序
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal class Bootstrap
    {
        /// <summary>
        /// 引导程序
        /// </summary>
        public static IBootstrap[] ServiceBootstraps
        {
            get
            {
                return new IBootstrap[]
                {
                    new TypeFinderBootstrap(),
                    new ProviderBootstrap(),
                    new StartBootstrap(),
                };
            }
        }
    }
}