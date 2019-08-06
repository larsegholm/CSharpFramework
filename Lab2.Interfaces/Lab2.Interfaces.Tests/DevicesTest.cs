using Moq;
using NUnit.Framework;

namespace Lab2.Interfaces.Tests {

    public class DevicesTest {

        private Mock<IOutput> OutputMock;

        [SetUp]
        public void Setup() {
            OutputMock = new Mock<IOutput>();
            OutputMock.Setup(output => output.WriteLine(It.IsAny<string>()));
        }

        [Test]
        public void AppleHeadsetReturnsNameInNameMethod() {
            var appleHeadSet = new AppleHeadset(OutputMock.Object);

            var name = appleHeadSet.Name();

            Assert.AreEqual(name, "AppleHeadset");
        }

        [Test]
        public void AppleHeadsetOutputsNameWhenPlayed() {
            var appleHeadSet = new AppleHeadset(OutputMock.Object);

            appleHeadSet.Play("");

            OutputMock.Verify(output => output.WriteLine(appleHeadSet.Name() + " sound"));
        }

        [Test]
        public void CastDisplayReturnsNameInNameMethod() {
            var castDisplay = new CastDisplay(OutputMock.Object);

            var name = castDisplay.Name();

            Assert.AreEqual(name, "CastDisplay");
        }

        [Test]
        public void CastDisplayShowsNameNameWhenDisplayed() {
            var castDisplay = new CastDisplay(OutputMock.Object);

            castDisplay.Display("");

            OutputMock.Verify(output => output.WriteLine("Displaying from " + castDisplay.Name()));
        }


        // Etc. etc.
    }
}
