using System;
using UnityEngine;

namespace OneFrame.Dependencies.Runtime
{
    [Serializable]
    public class Dependency<T> 
    {
        [SerializeField] private Component _dependency;

        private T _cache { get; set; }

        public virtual T Value
        {
            get
            {
                if (_cache != null) return _cache;

                if(_dependency == null) _dependency = DependencyLocator.Instance.Request<T>();   
                if(_dependency != null && _dependency.TryGetComponent(out T component)) _cache = component;
                else _cache = default;

                return _cache;
            }
        }

        public bool Resolve() => Value != null;
    }
}

