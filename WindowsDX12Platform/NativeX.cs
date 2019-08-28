using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace WindowsDX12Platform
{
    public class NativeX
    {

        [DllImport("nativedx.dll")]
        public extern static int InitNativeDx();

    }
}
