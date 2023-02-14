namespace CSharp_Assignment1
{
  class SchoolBuilder
  {
    //Fields
    public int Floors;
    public bool Classrooms;
    public bool Library;
    public bool TenisCourt;
    public bool SwimmingPool;

    public SchoolBuilder(int floors)
    {
      Floors = floors;
    }
    public SchoolBuilder SetClassrooms()
    {
      this.Classrooms = true;
      return this;
    }
    public SchoolBuilder SetLibrary()
    {
      this.Library = true;
      return this;
    }
    public SchoolBuilder SetTenisCourt()
    {
      this.TenisCourt = true;
      return this;
    }
    public SchoolBuilder SetSwimmingPool()
    {
      this.SwimmingPool = true;
      return this;
    }
    public School Build()
    {
      return new School(this);
    }
  }
}