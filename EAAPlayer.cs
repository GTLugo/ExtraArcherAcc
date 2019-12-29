using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace ExtraArcherAcc {
    public class EAAPlayer : ModPlayer {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>")]
        public override void clientClone(ModPlayer clientClone) {
            // Here we would make a backup clone of values that are only correct on the local players Player instance.
            EAAPlayer clone = clientClone as EAAPlayer;
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer) {
            ModPacket packet = mod.GetPacket();
            packet.Write((byte)EAAModMessageType.EAAPlayerSyncPlayer);
            packet.Write((byte)player.whoAmI);
            //packet.Write(serums);
            packet.Send(toWho, fromWho);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>")]
        public override void SendClientChanges(ModPlayer clientPlayer) {
            // Here we would sync something like an RPG stat whenever the player changes it.
            EAAPlayer clone = clientPlayer as EAAPlayer;

        }

        public override TagCompound Save() {
            return new TagCompound {
                //{"serums", serums},
            };
        }

        public override void Load(TagCompound tag) {
            //serums = tag.GetInt("serums");
        }

        public override void PostUpdateMiscEffects() {
            base.PostUpdateMiscEffects();

            //player.potionDelayTime = Item.potionDelay;
            //player.restorationDelayTime = Item.restorationDelay;
            //if (player.GetModPlayer<EAAPlayer>().hasMSeed) {
            //    player.potionDelayTime = (int)((double)player.potionDelayTime * (2.0 / 3.0));
            //    player.restorationDelayTime = (int)((double)player.restorationDelayTime * (2.0 / 3.0));
            //}
        }

        public override void ResetEffects() {

        }

        public override void GetHealLife(Item item, bool quickHeal, ref int healValue) {
            //if (player.GetModPlayer<EAAPlayer>().hasSeed || player.GetModPlayer<EAAPlayer>().hasMSeed)
            //    healValue = (int)(1.15 * healValue);
            base.GetHealLife(item, quickHeal, ref healValue);
        }

        public override bool ConsumeAmmo(Item weapon, Item ammo) {
            EAAPlayer modPlayer = Main.player[weapon.owner].GetModPlayer<EAAPlayer>();
            //if (!base.ConsumeAmmo(weapon, ammo)) return false;
            //Random rnd = new Random();
            //if (modPlayer.hasMag) {
            //    double saveChance = rnd.NextDouble();
            //    if (saveChance < 0.20) return false;
            //}
            //if (modPlayer.hasBeskarBreast) {
            //    double saveChance = rnd.NextDouble();
            //    if (saveChance < 0.30) return false;
            //}
            return base.ConsumeAmmo(weapon, ammo);
        }
    }
}