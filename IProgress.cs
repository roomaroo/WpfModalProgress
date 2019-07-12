using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalProgress
{
    public interface IProgress
    {
        string Message { get; set; }
        int Progress { get; set; }
    }
}
