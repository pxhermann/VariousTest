using System.ServiceProcess;

namespace WinServiceTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
//            ServiceBase[] ServicesToRun = new ServiceBase[]  {  new TestService()  };
//            ServiceBase.Run(ServicesToRun);

            ServiceBase.Run(new TestService());
        }
    }
}
