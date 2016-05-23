using Shouldly;
using Xunit;

namespace Container.Tests
{
    public class yeti_container_tests
    {
        [Fact]
        public void resolves_registerd_components()
        {
            var container = new YeTiContainer();
            container.Register<ITestInterface, TestImplementation>();

            var resolved_object = container.Resolve<ITestInterface>();

            resolved_object.ShouldBeOfType<TestImplementation>();

        }

        public interface ITestInterface
        {
             
        }

        private class TestImplementation : ITestInterface
        {
        }
    }
}