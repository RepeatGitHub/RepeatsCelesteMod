using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RepeatsCelesteMod.Content.Items.Materials
{
	public class Strawberry : ModItem
	{
		public override void SetDefaults() {
			Item.rare = ItemRarityID.White;
			Item.ResearchUnlockCount = 5;
			Item.DefaultToFood(32,36,BuffID.WellFed,3600*6);
		}
	}
}