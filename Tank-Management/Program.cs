using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Tank_Management
{
    internal static class Program
    {
        public static User user = new User();


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new UserDashboard());
        }
    }
}