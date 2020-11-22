using SimpleInjector;
using System.Reflection;

namespace DIContextAutoLoader.SimpleInjector
{
    public static class DIAutoLoaderExtensions
    {
        public static Container AutoLoadServices(
            this Container container,
            params Assembly[] assemblies)
        {
            var InstanceInjectionConfigurarions = ServiceInjectionManager
                .GetServicesInjectionConfigurarions(assemblies);

            foreach (var InstanceInjectionConfigurarion in InstanceInjectionConfigurarions)
            {
                if (InstanceInjectionConfigurarion.Lifetime == InjectionLifetime.Transient)
                {
                    container
                        .Register(
                            InstanceInjectionConfigurarion.ServiceType,
                            InstanceInjectionConfigurarion.ImplementationType,
                            Lifestyle.Transient);
                }
                else if (InstanceInjectionConfigurarion.Lifetime == InjectionLifetime.Scoped)
                {
                    container
                        .Register(
                            InstanceInjectionConfigurarion.ServiceType,
                            InstanceInjectionConfigurarion.ImplementationType,
                            Lifestyle.Scoped);
                }
                else if (InstanceInjectionConfigurarion.Lifetime == InjectionLifetime.Singleton)
                {
                    container
                        .Register(
                            InstanceInjectionConfigurarion.ServiceType,
                            InstanceInjectionConfigurarion.ImplementationType,
                            Lifestyle.Singleton);
                }
            }

            return container;
        }
    }
}
