using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class SearchSort
    {
        public  int SeqSearch(int X)
        {
            for (int i = 0; i < N; i++)
            {
                if (a[i] == X)
                    return i;
            }
            return -1;
        }
    }
}
