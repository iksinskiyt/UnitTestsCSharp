using Xunit;

public class testClass{

    [Fact]
    public void PassingAddTest(){
        Assert.Equal(4,Program.Add(2,2));
    }

    [Fact]
    public void FailingTest(){
        Assert.NotEqual(5,Program.Add(2,2));
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    public void Theory(int value){
        Assert.True(Program.IsOdd(value));
    }    

}