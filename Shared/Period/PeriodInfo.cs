using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazoriseTopHeaderSample.Shared.Period
{
    public class PeriodInfo
    {
        public PeriodInfo(Int32 code)
        {
            Code = code;
            Name = new DateOnly(code / 100, code % 100, 1).ToString("dd/MMMM");
        }
        public string Name { get; set; }
        public Int32 Code { get; set; }
    }
}
