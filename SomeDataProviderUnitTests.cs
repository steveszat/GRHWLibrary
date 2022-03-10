using GRHWLibrary;
using Moq;
using Xunit;

namespace GRHWLibraryTests
{
    public class SomeDataProviderUnitTests
    {
        [Fact]
        public void GetDataTest1()
        {
            Mock<ISomeFileReader> mockReader 
                = new Mock<ISomeFileReader>();
            mockReader.Setup(x => x.OpenFile())
                .Returns(new string[] 
                { "LastName,FirstName,Email,Color,2/2/2022" });
            var data = new SomeDataProvider()
                .GetData(mockReader.Object, ',');
            Assert.NotNull(data);
            Assert.Single(data);
            Assert.Equal("LastName", data[0].LastName);
            Assert.Equal("FirstName", data[0].FirstName);
            Assert.Equal("Email", data[0].Email);
            Assert.Equal("Color", data[0].FavoriteColor);
            Assert.Equal(new System.DateTime(2022, 2, 2), data[0].DateOfBirth);
        }
    }
}