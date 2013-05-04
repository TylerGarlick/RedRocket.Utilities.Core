using FlitBit.Wireup;
using FlitBit.Wireup.Meta;
using RedRocket.Utilities.Core.Tests;

[assembly: WireupDependency(typeof(FlitBit.Dto.AssemblyWireup))]
[assembly: WireupDependency(typeof(FlitBit.IoC.WireupThisAssembly))]
[assembly: Wireup(typeof(Wireup))]
namespace RedRocket.Utilities.Core.Tests
{
    public class Wireup : IWireupCommand
    {
        public void Execute(IWireupCoordinator coordinator)
        {

        }
    }
}
