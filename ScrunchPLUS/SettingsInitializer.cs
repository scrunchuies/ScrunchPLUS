using System;

namespace ScrunchPLUS
{
    class SettingsInitializer
    {
        //DiscordFields
        private DiscordRpc.EventHandlers _handlers;
        private DiscordRpc.RichPresence _presence;

        public void AutoLoginInitializer()
        {
            if (API.Login(ScrunchPLUS.Properties.Settings.Default.UserName, ScrunchPLUS.Properties.Settings.Default.Password))
            {
                Main main = new Main();
                main.Show();
            }
        }

        public void DiscordRpcLoginInitializer()
        {
            if (ScrunchPLUS.Properties.Settings.Default.DiscordRpc == "true")
            {
                //EpochTime
                TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
                int secondsSinceEpoch = (int)t.TotalSeconds;
                //Discord RPC
                this._handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("910304415498510406", ref this._handlers, true, null);
                this._handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("910304415498510406", ref this._handlers, true, null);
                this._presence.details = "HEE HEE HEE HAW";
                this._presence.state = "Logging in...";
                this._presence.largeImageKey = "logo";
                this._presence.largeImageText = "ScrunchPLUS";
                this._presence.startTimestamp = secondsSinceEpoch;
                DiscordRpc.UpdatePresence(ref this._presence);
            }
        }

        public void DiscordRpcMainInitializer()
        {
            if (ScrunchPLUS.Properties.Settings.Default.DiscordRpc == "true")
            {
                //Discord RPC
                TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
                int secondsSinceEpoch = (int)t.TotalSeconds;
                this._handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("910304415498510406", ref this._handlers, true, null);
                this._handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("910304415498510406", ref this._handlers, true, null);
                this._presence.details = "HAW HAW HAW HEE";
                this._presence.state = "Browsing main menu...";
                this._presence.largeImageKey = "logo";
                this._presence.largeImageText = "ScrunchPLUS";
                this._presence.startTimestamp = secondsSinceEpoch;
                DiscordRpc.UpdatePresence(ref this._presence);
            }
        }
    }
}
