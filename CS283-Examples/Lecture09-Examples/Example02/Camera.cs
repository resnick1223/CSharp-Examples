using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class Camera
    {
        private List<Plugin> plugins;

        public Camera()
        {
            plugins = new List<Plugin>();
        }

        public string TakePhoto()
        {
            string image = "原始圖片 包含人臉";

            foreach (var plugin in plugins)
            {
                if (plugin != null && plugin is IFilter && plugin.Enabled)
                {
                    IFilter filter = plugin as IFilter;
                    image = filter.ApplyFilter(image);
                }
            }

            return image;
        }

        public Camera InstallPlugin(Plugin plugin)
        {
            this.plugins.Add(plugin);
            return this;
        }

        public List<Plugin> FilterList
        {
            get
            {
                List<Plugin> filterList = new List<Plugin>();
                foreach (var plugin in plugins)
                {
                    if (plugin is IFilter)
                        filterList.Add(plugin);
                }
                return filterList;
            }
        }

        public Camera EnablePlugin(string name)
        {
            foreach (var plugin in plugins)
            {
                if (plugin.Name == name)
                {
                    plugin.Enabled = true;
                    break;
                }
            }

            return this;
        }

        public Camera DisablePlugin(string name)
        {
            foreach (var plugin in plugins)
            {
                if (plugin.Name == name)
                {
                    plugin.Enabled = false;
                    break;
                }
            }

            return this;
        }
    }
}