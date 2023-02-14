namespace CSharp_Assignment1
{
  abstract class PageTemplate
  {
    protected abstract void CreateHeader();
    protected abstract void CreateNavigation();
    protected abstract void CreateBody();
    protected abstract void CreateFooter();

    public void DisplayPage()
    {
      CreateHeader();
      CreateNavigation();
      CreateBody();
      CreateFooter();
    }
  }

  class LoginPage : PageTemplate
  {
    protected override void CreateHeader()
    {
      System.Console.WriteLine("Create header for login page");
    }

    protected override void CreateNavigation()
    {
      System.Console.WriteLine("Create navigation for login page");
    }

    protected override void CreateBody()
    {
      System.Console.WriteLine("Create body for login page");
    }

    protected override void CreateFooter()
    {
      System.Console.WriteLine("Create footer for login page");
    }
  }

  class LandingPage : PageTemplate
  {
    protected override void CreateHeader()
    {
      System.Console.WriteLine("Create header for landing page");
    }

    protected override void CreateNavigation()
    {
      System.Console.WriteLine("Create navigation for landing page");
    }

    protected override void CreateBody()
    {
      System.Console.WriteLine("Create body for landing page");
    }

    protected override void CreateFooter()
    {
      System.Console.WriteLine("Create footer for landing page");
    }
  }

  class DashboardPage : PageTemplate
  {
    protected override void CreateHeader()
    {
      System.Console.WriteLine("Create header for dashboard page");
    }

    protected override void CreateNavigation()
    {
      System.Console.WriteLine("Create navigation for dashboard page");
    }

    protected override void CreateBody()
    {
      System.Console.WriteLine("Create body for dashboard page");
    }

    protected override void CreateFooter()
    {
      System.Console.WriteLine("Create footer for dashboard page");
    }
  }

  class Template
  {
    static void Main(string[] args)
    {
      PageTemplate loginPage = new LoginPage();
      loginPage.DisplayPage();
      Console.WriteLine("---");
      PageTemplate landingPage = new LandingPage();
      landingPage.DisplayPage();
      Console.WriteLine("---");
      PageTemplate dashboardPage = new DashboardPage();
      dashboardPage.DisplayPage();
    }
  }
}