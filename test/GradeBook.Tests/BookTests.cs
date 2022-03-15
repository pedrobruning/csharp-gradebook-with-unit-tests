using Xunit;

namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void Test1()
    {
        //arrange
        var sut = new Book("");
        sut.AddGrade(89.1);
        sut.AddGrade(90.5);
        sut.AddGrade(77.3);

        //act
        var result = sut.GetStatistics();        

        //assert
        Assert.Equal(85.6, result.Average, 1);
        Assert.Equal(90.5, result.High, 1);
        Assert.Equal(77.3, result.Low, 1);
    }
}