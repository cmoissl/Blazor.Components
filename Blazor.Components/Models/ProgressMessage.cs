using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMoissl.Blazor.Components.Models
{
    public class ProgressMessage
    {
        public bool IsBusy { get; set; }
        public int ProgressInPercent { get; set; }
        public string Message { get; set; }
    }
}
