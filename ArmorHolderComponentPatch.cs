using Aki.Reflection.Patching;
using EFT.InventoryLogic;
using HarmonyLib;
using System.Reflection;

namespace RaiRai.UnrestrictedPlates
{
    internal class ArmorHolderComponentPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(ArmorHolderComponent), nameof(ArmorHolderComponent.method_1));
        }

        [PatchPrefix]
        private static void ArmorPlateFix(ref ArmorHolderComponent.EArmorPlateFiltering filtering)
        {
            if (filtering == ArmorHolderComponent.EArmorPlateFiltering.Locked)
            {
                filtering = ArmorHolderComponent.EArmorPlateFiltering.Both;
            }
        }
    }
}
