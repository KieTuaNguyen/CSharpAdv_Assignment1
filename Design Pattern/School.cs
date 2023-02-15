using System.Text;

namespace CSharp_Assignment1
{
  class School
  {
    //Fields
    int _floors;
    bool _classrooms;
    bool _library;
    bool _tenisCourt;
    bool _swimmingPool;

    //Constructor
    public School(SchoolBuilder schoolBuilder)
    {
      _floors = schoolBuilder.Floors;
      _classrooms = schoolBuilder.Classrooms;
      _library = schoolBuilder.Library;
      _tenisCourt = schoolBuilder.TenisCourt;
      _swimmingPool = schoolBuilder.SwimmingPool;
    }

    //Method
    public string GetSchoolInfo()
    {
      var schoolInfo = new StringBuilder();
      schoolInfo.AppendLine($"School has {_floors} floors");
      schoolInfo.AppendLine($"School has classrooms: {_classrooms}");
      schoolInfo.AppendLine($"School has library: {_library}");
      schoolInfo.AppendLine($"School has tenis court: {_tenisCourt}");
      schoolInfo.AppendLine($"School has swimming pool: {_swimmingPool}");
      return schoolInfo.ToString();
    }
  }

  class Test
  {
    static void Main(string[] args)
    {
      //Create greenwich object
      School greenwich = new SchoolBuilder(3)
        .SetClassrooms()
        .SetLibrary()
        .SetTenisCourt()
        .SetSwimmingPool()
        .Build();
      Console.WriteLine(greenwich.GetSchoolInfo());
      Console.WriteLine("---");
      //Create dut object
      School dut = new SchoolBuilder(5)
        .SetClassrooms()
        .SetLibrary()
        .Build();
      Console.WriteLine(dut.GetSchoolInfo());
    }
  }
}