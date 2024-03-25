using OneFrame.Dependencies.Runtime;
using UnityEngine;

namespace OneFrame.Dependencies.Examples
{
    public class ServiceUser : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private Dependency<IService> _dependencyA;
        [SerializeField] private Dependency<ServiceB> _dependencyB;
        [SerializeField] private Dependency<Camera> _dependencyC;

        [Header("Other References")]
        [SerializeField] private Rigidbody2D _rb;

        private void Start()
        {
            Debug.Log($"<b>Dependency A: {_dependencyA.Resolve()}</b>");
            Debug.Log($"<b>Dependency B: {_dependencyB.Resolve()}</b>");
            Debug.Log($"<b>Dependency C: {_dependencyC.Resolve()}</b>");

            _dependencyA.Value?.Execute();
            _dependencyB.Value?.Execute();
        }
    }
}

