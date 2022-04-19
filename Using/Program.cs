using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using//Using used when have name sapace then we used as using 
 //2, used IDesposible interface ko db command impliment karta hai to uske under Dispose class hota hain and 
 //Idesposible ke under Dispose method hota hain
 //namspace me 
 //Idisposible interface
 //MVC project me
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection cn = new SqlConnection())
            {
            }
            using (SqlCommand cmd = new SqlCommand())
            {

            }
        }
    }
}
