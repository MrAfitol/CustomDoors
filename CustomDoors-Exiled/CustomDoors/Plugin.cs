using Exiled.API.Features;
using System;
using Server = Exiled.Events.Handlers.Server;

namespace CustomDoors
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "MrAfitol";
        public override string Name { get; } = "CustomDoor";
        public override string Prefix { get; } = "customdoor";
        public override Version RequiredExiledVersion => new Version(2, 10, 0);
        public override Version Version => new Version(1, 0, 0);

        public static Plugin Instance;

        private EventHandlers handler;

        public override void OnEnabled()
        {
            handler = new EventHandlers();
            Instance = this;
            Server.RoundStarted += handler.OnRoundStarted;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Server.RoundStarted -= handler.OnRoundStarted;
            handler = null;

            base.OnDisabled();
        }
    }
}
