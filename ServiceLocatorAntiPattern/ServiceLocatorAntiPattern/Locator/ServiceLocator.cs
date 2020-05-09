using System;
using System.Collections.Generic;

namespace ServiceLocatorAntiPattern.Locator
{
    public static class ServiceLocator
    {
        private readonly static Dictionary<Type, Func<object>>
            services = new Dictionary<Type, Func<object>>();

        public static void Register<TService, TImplementation>(Func<TImplementation> resolver)
            where TImplementation : class, TService

        {
            services[typeof(TService)] = () => resolver();
        }

        public static TService Resolve<TService>()
        {
            return (TService)services[typeof(TService)]();
        }

        public static void Reset()
        {
            services.Clear();
        }
    }
}