using System;
using System.Collections.Generic;

namespace ServiceLocatorAntiPattern
{
    public static class ServiceLocator
    {
        private readonly static Dictionary<Type, Func<object>>
            services = new Dictionary<Type, Func<object>>();

        public static void Register<T>(Func<T> resolver)
        {
            services[typeof(T)] = () => resolver();
        }

        public static T Resolve<T>()
        {
            return (T)services[typeof(T)]();
        }

        public static void Reset()
        {
            services.Clear();
        }
    }
}