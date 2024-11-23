using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13
{
    public  class ParamsCollection
    {
        public static string ConcateList(params List<Data> list)
        {
            return string.Join(", ", list); 
        }

        public static void Run()
        {
            var data = Data.GetData();
            var result = ParamsCollection.ConcateList(data);
            Console.WriteLine(result);
        }
    }

    public class Data
    {
        public int Id; 
        public string Name;

        public override string ToString()
        {
            return $"{nameof(Id)}:{Id}, {nameof(Name)}:{Name}";
        }

        public static List<Data> GetData()
        {
            return new List<Data>()
            {
                new Data(){Id=1, Name="First"},
                new Data(){Id=2, Name="Second"}
            };
        }
    }


}
