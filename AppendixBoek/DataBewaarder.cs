using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendixBoek
{
    class DataBewaarder<TWaarde1, TWaarde2>
    {
        public TWaarde1 Waarde1 { get; set; }
        public TWaarde2 Waarde2 { get; set; }

        public DataBewaarder(TWaarde1 waarde1, TWaarde2 waarde2)
        {
            Waarde1 = waarde1;
            Waarde2 = waarde2;
        }
    }
}
