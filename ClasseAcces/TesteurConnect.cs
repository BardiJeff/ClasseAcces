using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClasseAcces
{
    public class TesteurConnect
    {
        static void Main(string[] args)
        {

            try
            {
                //AccesEMP test = new  AccesEMP();
                //test.ConnectBase();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
