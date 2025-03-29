using Exiled.API.Features;
using System;

namespace RulesCommand
{
    public class Plugin : Plugin<Config, Translations>
    {
        public static Plugin Instance { get; private set; } = null;
        public override string Author => "waltuh";
        public override string Name => "RulesCommand";
        public override string Prefix => "RC";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
            Instance = this;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Instance = null;
        }
    }
}
