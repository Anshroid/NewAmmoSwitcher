using Terraria.ModLoader;

namespace NewAmmoSwitcher
{
	public class NewAmmoSwitcher : Mod
	{
        public static ModHotKey SwapAmmo12Hotkey;
        public static ModHotKey SwapAmmo34Hotkey;

        public override void Load()
        {
            SwapAmmo12Hotkey = RegisterHotKey("Swap Ammo Slots 1+2", "F");
            SwapAmmo34Hotkey = RegisterHotKey("Swap Ammo Slots 3+4", "Q");
        }

        public override void Unload()
        {
            SwapAmmo12Hotkey = null;
            SwapAmmo34Hotkey = null;
        }
    }
}