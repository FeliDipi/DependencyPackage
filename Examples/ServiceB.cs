using OneFrame.Dependencies.Runtime;
using UnityEngine;

namespace OneFrame.Dependencies.Examples
{
    public class ServiceB : DependencyService, IService
    {
        public void Execute()
        {
            Debug.Log("<b>Service B used</b>");
        }
    }
}
