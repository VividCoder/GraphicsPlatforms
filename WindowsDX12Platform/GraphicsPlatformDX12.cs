using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsPlatform;

namespace WindowsDX12Platform
{
    public class GraphicsPlatformDX12 : GraphicsPlatform.GraphicsPlatform
    {

        public override void InitWindow(string title, int width, int height, bool fullscreen)
        {

            Console.WriteLine("Creating DX12 Window. W:" + width + " H:" + height + " Full:" + fullscreen);
            Console.WriteLine("InitDX return:"+ NativeX.InitNativeDx());

            //base.InitWindow(title, width, height, fullscreen);

        }

    }
}
