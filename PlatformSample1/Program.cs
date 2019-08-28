using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VividEngine;

namespace PlatformSample1
{

    public class TestDX12 : VividEngine.App.VividApp
    {

        public TestDX12() : base(new WindowsDX12Platform.GraphicsPlatformDX12(),800,600,"Test Dx12",false)
        {

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var app = new TestDX12();

            app.Run();

        }
    }
}
