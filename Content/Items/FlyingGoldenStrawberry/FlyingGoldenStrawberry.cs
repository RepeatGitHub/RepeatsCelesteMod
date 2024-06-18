using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RepeatsCelesteMod.Content.Items.FlyingGoldenStrawberry
{
	public class FlyingGoldenStrawberry : ModItem
	{
		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.ZephyrFish); // Copy the Defaults of the Zephyr Fish Item.
			Item.rare = ItemRarityID.LightRed;

			Item.shoot = ModContent.ProjectileType<FlyingGoldenStrawberryProjectile>(); // "Shoot" your pet projectile.
			Item.buffType = ModContent.BuffType<FlyingGoldenStrawberryBuff>(); // Apply buff upon usage of the Item.
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(Item.buffType, 3600);
			}
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.GoldCrown)
				.AddIngredient(ItemID.LunarBar)
				.AddIngredient<FlyingStrawberry.FlyingStrawberry>()
				.AddTile(TileID.CookingPots)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.PlatinumCrown)
				.AddIngredient(ItemID.LunarBar)
				.AddIngredient<FlyingStrawberry.FlyingStrawberry>()
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}
}