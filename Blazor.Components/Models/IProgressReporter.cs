using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMoissl.Blazor.Components.Models
{
    public interface IProgressReporter : IProgress<ProgressMessage>
    {
        void Report(ProgressMessage value);
        Task ReportAsync(ProgressMessage value);
    }
}
