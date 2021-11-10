using System;
using System.Collections.Generic;
using System.Text;

namespace TestApplication.Common.Utilities
{
    public class PaginationHeader
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
    }
}
