using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceRest_20180140072_Nuraini;

namespace ServerConfigRest_20180140072_Nuraini
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostobjek = null;

            try
            {
                hostobjek = new ServiceHost(typeof(TI_UMY));
                hostobjek.Open();
                Console.WriteLine("Server ready...");
                Console.ReadLine();
                hostobjek.Close();
            }
            catch (Exception ex)
            {
                hostobjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}