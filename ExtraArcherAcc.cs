using System.IO;
using Terraria;
using Terraria.ModLoader;

namespace ExtraArcherAcc
{
	public class ExtraArcherAcc : Mod {
        internal static ExtraArcherAcc Instance;

        public ExtraArcherAcc() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void HandlePacket(BinaryReader reader, int whoAmI) {
            EAAModMessageType msgType = (EAAModMessageType)reader.ReadByte();
            switch (msgType) {
                // This message syncs ExamplePlayer.exampleLifeFruits
                case EAAModMessageType.EAAPlayerSyncPlayer:
                    byte playernumber = reader.ReadByte();
                    EAAPlayer modPlayer = Main.player[playernumber].GetModPlayer<EAAPlayer>();
                    //int serums = reader.ReadInt32();
                    //modPlayer.serums = serums;
                    // SyncPlayer will be called automatically, so there is no need to forward this data to other clients.
                    break;
                default:
                    //.WarnFormat("ExtraGunGear: Unknown Message type: {0}", msgType);
                    break;
            }
            //ModNetHandler.HandlePacket(reader, whoAmI);
        }
    }

    internal enum EAAModMessageType : byte {
        EAAPlayerSyncPlayer
    }
}