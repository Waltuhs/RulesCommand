using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RulesCommand
{
    public sealed class Config : IConfig
    {
        [Description("is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("is Debug mode enabled?")]
        public bool Debug { get; set; } = false;
    }
}
