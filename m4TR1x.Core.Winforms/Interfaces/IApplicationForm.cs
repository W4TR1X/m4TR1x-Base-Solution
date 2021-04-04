using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace m4TR1x.Core.Winforms.Interfaces
{
    public interface IApplicationForm
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public string Name { get; set; }

        public ControlCollection Controls { get; }

        public bool InvokeRequired { get; }

#nullable enable
        public event EventHandler? Disposed;
#nullable disable

        public object Invoke(Delegate method);
        public object Invoke(Delegate method, params object[] args);

        public IntPtr Handle { get; }

        public void Dispose();
    }
}
