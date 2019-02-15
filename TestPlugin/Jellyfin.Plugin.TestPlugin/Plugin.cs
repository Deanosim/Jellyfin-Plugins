using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using Jellyfin.Plugin.TestPlugin;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Model.Drawing;


namespace Jellyfin.Plugin.TestPlugin
{
    /// <summary>
    /// 
    /// </summary>
    public class Plugin : BasePlugin<BasePluginConfiguration>, IHasWebPages
    {
        public static ILogger { get; set; }

    public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
    }

    public IEnumerable<PluginPageInfo> GetPages()
    {
        return new[]
        {
            new PluginPageInfo
            {
                Name = "TestPlugin",
                EmbeddedResourcePath = GetType().Namespace + ".Configuration.configPage.html"
            }
        };
    }
    /// <summary>
    /// Gets the the plugin description.
    /// </summary>
    private Guid _id = new Guid("D4E37AF4-2FBB-45D5-BEB7-E16A1D7D6770");
    public override Guid Id
    {
        get { return _id; }
    }
    public override string Description
    {
        get
        {
            return "A Test Plugin by Deanosim";
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static Plugin Instance { get; private set; }
    }
}
