using FlitBit.Wireup;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RedRocket.Utilities.Core.Tests
{
    public abstract class AbstractTests
    {
        [TestInitialize]
        public void Init()
        {
            WireupCoordinator.SelfConfigure();
        }
    }
}