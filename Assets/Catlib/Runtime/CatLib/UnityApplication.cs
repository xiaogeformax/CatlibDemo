using UnityEngine;

namespace CatLib
{
    internal sealed class UnityApplication : Application
    {
        /// <summary>
        /// Unity Application
        /// </summary>
        /// <param name="component">根组件</param>
        public UnityApplication(Component component)
        {
            Instance(Type2Service(typeof(Component)), component);
          
        }
      
    }
}
