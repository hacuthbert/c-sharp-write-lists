using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_write_lists
{
    internal class Utilities
    {
        public class KitList
        {
            public int KitNumber { get; set; }
            public int SequenceNumber { get; set; }
            public string KitType { get; set; }

            public KitList(int kitnum, int seqnum, string kittype)
            {
                KitNumber = kitnum;
                SequenceNumber = seqnum;
                KitType = kittype;
            }
        }
    }
}
