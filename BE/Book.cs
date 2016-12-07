using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Book : IEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublication { get; set; }
        public int Pages { get; set; }
        public int CopiesAvailable { get; set; }
        public byte[] Image { get; set; }
    }
}
