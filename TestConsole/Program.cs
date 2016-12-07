using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;
using MongoDB.Bson;

namespace TestConsole
{
    class Program
    {
        static IBL bl_adapter;
        static void Main(string[] args)
        {
            bl_adapter = BL_imp.Insatnce;
            var coll = bl_adapter.GetBooksByAuthor("b");
            var c = bl_adapter.GetBooksByTitle("e");
            var y = bl_adapter.GetBookById(c[0].Id.ToString());
            Console.WriteLine(coll[0].Author);
        }
    }
}
