// See https://aka.ms/new-console-template for more information
namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Pedro`s Grade Book", new List<double>() { 12.7, 10.3, 6.11, 4.1 });
      book.ShowStatistics();      
    }
  }
}