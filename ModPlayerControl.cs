using System;
using Terraria.GameInput;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace NewAmmoSwitcher
{
    class ModPlayerControl : ModPlayer
    {
        static readonly int InvAmmoSlot1 = 54;
        static readonly int InvAmmoSlot2 = 55;
        static readonly int InvAmmoSlot3 = 56;
        static readonly int InvAmmoSlot4 = 57;

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (NewAmmoSwitcher.SwapAmmo12Hotkey.JustPressed)
            {
                Item AmmoSlot1 = player.inventory[InvAmmoSlot1];

                Item AmmoSlot2 = player.inventory[InvAmmoSlot2];

                mod.Logger.Info(string.Format("AmmoSwitcher: Switching {0} x{1} with {2} x{3}", AmmoSlot1.netID.ToString(), AmmoSlot1.stack.ToString(), AmmoSlot2.netID.ToString(), AmmoSlot2.stack.ToString()));

                player.inventory[InvAmmoSlot1] = AmmoSlot2;
                player.inventory[InvAmmoSlot2] = AmmoSlot1;

            };
            if (NewAmmoSwitcher.SwapAmmo34Hotkey.JustPressed)
            {
                Item AmmoSlot3 = player.inventory[InvAmmoSlot3];

                Item AmmoSlot4 = player.inventory[InvAmmoSlot4];

                mod.Logger.Info(string.Format("AmmoSwitcher: Switching {0} x{1} with {2} x{3}", AmmoSlot3.netID.ToString(), AmmoSlot3.stack.ToString(), AmmoSlot4.netID.ToString(), AmmoSlot4.stack.ToString()));

                player.inventory[InvAmmoSlot3] = AmmoSlot4;
                player.inventory[InvAmmoSlot4] = AmmoSlot3;
            }
        }
    }
}
