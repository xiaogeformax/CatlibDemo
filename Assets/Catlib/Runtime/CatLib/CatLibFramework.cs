using System.Collections.Generic;
using UnityEngine;

namespace CatLib
{
    [DisallowMultipleComponent]
    [AddComponentMenu("CatLib/Framework")]
    public sealed class CatLibFramework : MonoBehaviour
    {
        /// <summary>
        /// Unity Start
        /// </summary>
        public void Start()
        {
            var gameBox = new UnityApplication(this);
            gameBox.Bootstrap(GetBootstraps());
            gameBox.Init();

        }

        /// <summary>
        /// 获取引导程序
        /// </summary>
        /// <returns>引导脚本</returns>
        private IBootstrap[] GetBootstraps()
        {
            var bootstraps = new List<IBootstrap>();
            bootstraps.AddRange(GetComponents<IBootstrap>());
            bootstraps.AddRange(Bootstrap.ServiceBootstraps);
            return bootstraps.ToArray();
        }
    }
}