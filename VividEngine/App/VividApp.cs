using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsPlatform;

namespace VividEngine.App
{
    public class AppInfo
    {
        public static int Width
        {
            get;
            set;
           

            
        }
        public static int Height
        {
            get;
            set;
        }
        public static int TargetWidth
        {
            get;
            set;
        }
        public static int TargetHeight
        {
            get;
            set;
        }
        public static string Name
        {
            get;
            set;
        }

        public static bool Fullscreen
        {
            get;
            set;
        }

    }
    public class VividApp
    {
        
        public GraphicsPlatform.GraphicsPlatform Platform
        {
            get;
            set;
        }

        public VividApp(GraphicsPlatform.GraphicsPlatform platform,int width,int height,string title,bool fullscreen = false)
        {

            Platform = platform;
            AppInfo.Width = width;
            AppInfo.Height = height;
            AppInfo.TargetWidth = width;
            AppInfo.TargetHeight = height;
            AppInfo.Name = title;
            AppInfo.Fullscreen = fullscreen;
        



        }

        public virtual void Run()
        {

            Platform.InitWindow(AppInfo.Name, AppInfo.Width, AppInfo.Height, AppInfo.Fullscreen);

            while (true)
            {

            }

        }

    }
}
