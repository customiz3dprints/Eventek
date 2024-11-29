using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using Exiled.Loader;
using System;
using player = Exiled.Events.Handlers.Player;

namespace eventek
{
    public class Class1 : Plugin<Config>
    {
        public static Class1 Instance;
        public override string Name => "EventHelper";
        public override string Author => "MedveMarci, DDani6";
        public override void OnEnabled()
        {
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            base.OnDisabled();
        }

        public override void OnReloaded()
        {

            base.OnReloaded();
        }
    }

}
