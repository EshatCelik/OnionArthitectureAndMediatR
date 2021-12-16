using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Parameters
{
    public class RequestParameters
    {

        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public RequestParameters(int pagesize, int pagenumber)
        {
            this.PageSize = pagesize;
            this.PageNumber = pagenumber;
        }
    }
}
