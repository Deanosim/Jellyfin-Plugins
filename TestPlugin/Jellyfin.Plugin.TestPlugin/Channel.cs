using System;
using System.Collections.Generic;
using MediaBrowser.Controller.Channels;
using MediaBrowser.Controller.Drawing;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Channels;
using MediaBrowser.Model.Drawing;
using MediaBrowser.Model.Entities;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Model.Reflection;
using MediaBrowser.Model.Dto;

namespace Jellyfin.Plugin.TestPlugin
{
    class Channel : IChannel, IHasCacheKey
    {
        private readonly ILogger _logger;
        private IAssemblyInfo _assemblyInfo;

        public Channel(ILogger loggerFactory, IAssemblyInfo assemblyInfo)
        {
            _logger = loggerFactory.CreateLogger(GetType().Name);
            _assemblyInfo = assemblyInfo;
        }

        public string DataVersion
        {
            get
            {
                return "1";
            }
        }

        public async Task<ChannelItemResult> GetChannelItems(InternalChannelItemQuery) query, CanellationToken canellationToken)
    }
}
