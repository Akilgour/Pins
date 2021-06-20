using Autofac;
using Pins.Domain.Autofac;
using System.Linq;

namespace Pins.Application.Autofac
{
    public class PinApplicaitonModule : Module
    {
        public PinApplicaitonModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new PinDomainModule());

            //"ThisAssembly" means "any types in the same assembly as the module"
            builder.RegisterAssemblyTypes(ThisAssembly)
                 .Where(t => t.Name.EndsWith("Service"))
                 .AsImplementedInterfaces();
        }
    }
}