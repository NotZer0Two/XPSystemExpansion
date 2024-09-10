using Exiled.API.Features;
using PlaceholderAPI.API.Abstract;
using XPSystem.API;
using XPSystem.API.StorageProviders;
using XPSystem.API.StorageProviders.Models;

namespace XPSystemExpansion
{
    public class XPSystemExpansion : PlaceholderExpansion
    {
        public override string Author { get; set; } = "NotZer0Two";
        public override string Identifier { get; set; } = "xpsystem";
        public override string RequiredPlugin { get; set; } = "XPSystem";

        public override string OnRequest(Player player, string param)
        {
            if (!XPExtensions.TryParseUserId(player.UserId, out PlayerId id))
                return null;

            PlayerInfoWrapper xpplayer = XPExtensions.GetPlayerInfo(id);

            switch (param.ToLower())
            {
                case "xp":
                    return xpplayer.XP.ToString();

                case "level":
                    return xpplayer.Level.ToString();

                case "xpneedednext":
                    return xpplayer.NeededXPNext.ToString();

                case "xpneededcurrent":
                    return xpplayer.NeededXPCurrent.ToString();
            }

            return null;
        }
    }
}
