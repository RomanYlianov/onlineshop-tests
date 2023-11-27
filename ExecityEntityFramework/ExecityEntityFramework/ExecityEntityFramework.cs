using Microsoft.Extensions.Configuration;

namespace ExecityEntityFramework
{
    public class TestEntityFrameworkConnection
    {
        public static bool TestConnection()
        {

            bool isConnect = false;

            try
            {
                var builder = new ConfigurationBuilder();

                builder.SetBasePath(Directory.GetCurrentDirectory());

                // builder.AddJsonFile("appsettings.json");

                var config = builder.Build();


                using (AppDbContext context = new AppDbContext())
                {
                    isConnect = true;

                    Console.WriteLine("connection successful");

                }
      
            }
            catch
            {
                Console.WriteLine("connection failed");
            }

            return isConnect;
        }
    }
}