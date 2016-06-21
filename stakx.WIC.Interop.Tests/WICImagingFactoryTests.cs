using NUnit.Framework;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop.Tests
{
    [TestFixture]
    public sealed class WICImagingFactoryTests
    {
        [Test]
        public void WICImagingFactory_Instantiation_Succeeds()
        {
            IWICImagingFactory imagingFactory = null;

            TestDelegate instantiation = delegate
            {
                imagingFactory = new WICImagingFactory();
            };

            Assert.DoesNotThrow(instantiation);
            Assert.IsNotNull(imagingFactory);
            Assert.IsTrue(Marshal.IsComObject(imagingFactory));
        }
    }
}
