using Autofac;
using Pins.Domain.Context;
using System.Linq;

namespace Pins.Domain.Autofac
{
    public class PinDomainModule : Module
    {
        public PinDomainModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .WithParameter("context", new PinsContext())
                .AsImplementedInterfaces();
        }
    }
}