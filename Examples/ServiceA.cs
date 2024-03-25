using OneFrame.Dependencies.Runtime;
using UnityEngine;

namespace OneFrame.Dependencies.Examples
{
    public class ServiceA : DependencyService, IService
    {
        public void Execute()
        {
            Debug.Log("<b>Service A used</b>");

            DependencyLocator.Instance.UnRegister(this);
        }
    }
}
