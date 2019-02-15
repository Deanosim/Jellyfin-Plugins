using System;
using MediaBrowser.Model.MediaInfo;
using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.TestPlugin.Configuration
{

    public class PluginConfiguration : BasePluginConfiguration
    {


        public Bookmark[] Bookmarks { get; set; }


        public PluginConfiguration()
        {
            Bookmarks = new Bookmark[] { };
        }
    }

    public class Bookmark
    {
        public String Name { get; set; }
        public String Image { get; set; }
        public String Path { get; set; }
        public MediaProtocol Protocol { get; set; }
        public String UserId { get; set; }
    }
}
