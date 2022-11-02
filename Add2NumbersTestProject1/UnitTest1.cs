using Add2NumbersService;

namespace Add2NumbersTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            //arrange
            int expected = 3;
            int actual;
            //act
            Add2NumbersClass add2NumbersClass = new Add2NumbersClass();
            actual = await add2NumbersClass.Add2NumbersFunction("1", "2");
            //assert
            Assert.Equal(expected, actual); 
        }
    }
}