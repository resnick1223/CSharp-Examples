using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Camera camera = new Camera();
            Console.WriteLine(camera.TakePhoto());

            Console.WriteLine(
                camera
                .InstallPlugin(new Mono())
                .InstallPlugin(new Noir())
                .InstallPlugin(new BeautifyFace())
                .InstallPlugin(new HDR())
                .EnablePlugin("黑白")
                .EnablePlugin("HDR")
                .EnablePlugin("美顏相機")
                .TakePhoto()
            );

            Console.WriteLine("列出所有濾鏡");
            foreach (var plugin in camera.FilterList)
            {
                Console.WriteLine("濾鏡名稱:{0}, 啟用:{1}", plugin.Name, plugin.Enabled);
            }
        }
    }
}