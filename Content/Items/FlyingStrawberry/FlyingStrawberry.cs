using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RepeatsCelesteMod.Content.Items.FlyingStrawberry
{
	public class FlyingStrawberry : ModItem
	{
		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.ZephyrFish); // Copy the Defaults of the Zephyr Fish Item.
			Item.rare = ItemRarityID.LightRed;

			Item.shoot = ModContent.ProjectileType<FlyingStrawberryProjectile>(); // "Shoot" your pet projectile.
			Item.buffType = ModContent.BuffType<FlyingStrawberryBuff>(); // Apply buff upon usage of the Item.
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(Item.buffType, 3600);
			}
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Cloud,10)
				.AddIngredient<Materials.Strawberry>()
				.AddIngredient(ItemID.Cloud,10)
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}
}