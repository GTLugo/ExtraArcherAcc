﻿using ExtraArcherAcc;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraArcherAcc {
    public class EAAGlobalItem : GlobalItem {
        private static int count = 0;
        public override bool CanUseItem(Item item, Player player) {
            //if (item.ranged && player.GetModPlayer<EAAPlayer>().hasStock && player.altFunctionUse != 2) {
            //    item.autoReuse = true;
            //}
            //else if (item.ranged && !player.GetModPlayer<EAAPlayer>().hasStock && player.altFunctionUse != 2) {
            //    Item itemClone = item.Clone();
            //    itemClone.CloneDefaults(item.type);
            //    item.autoReuse = itemClone.autoReuse;
            //}

            return base.CanUseItem(item, player);
        }

        //public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
        //    Main.NewText("Modified Shoot " + count++);
        //    if (item.ranged) {
        //        //Main.NewText("item is ranged");
        //        if (player.GetModPlayer<EGGPlayer>().hasMuzzle) {
        //            //Main.NewText("player has muzzle");
        //            if (type == ProjectileID.Bullet || type == ProjectileID.BulletHighVelocity) {
        //                //Main.NewText("bullet is hitscan");
        //                //type = mod.ProjectileType("HitScan");
        //            }
        //            else if (type == ProjectileID.ChlorophyteBullet) {
        //                //Main.NewText("bullet is homing hitscan");
        //                //type = mod.ProjectileType("HitScanHoming");
        //            }
        //        }
        //    }
        //    return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        //}
    }
}
