namespace SimpleAPI.Tests.Tests
{
    using SimpleAPI.Controllers;
    using Xunit;

    public class ValuesControllerTests
    {
        private readonly ValuesController controller;
        public ValuesControllerTests()
        {
            this.controller = new ValuesController();
        }

        //[Fact]
        //public void WhenIndexCalled_ShouldReturn_Values()
        //{
        //    Assert.Equal(, this.controller.Get());
        //}

        [Fact]
        public void WhenGetWithIdCalled_Returns_ActualDetailsForId()
        {
            Assert.Equal("this", this.controller.Get(1).Value);
        }
    }
}
