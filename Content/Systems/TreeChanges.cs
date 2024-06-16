using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using RepeatsCelesteMod.Content.Items.Materials;
using Terraria;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.Personalities;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace RepeatsCelesteMod.Content.Systems
{
	// This example uses a GlobalTile to affect the properties of an existing tile.
	// Tweaking existing tiles is doable to some degree.
	public class TreeChanged : ModSystem
	{
		public override void Load() {
            On_WorldGen.ShakeTree += StrawberryLoot;
		}

        private void StrawberryLoot(On_WorldGen.orig_ShakeTree orig, int i, int j) {
            orig(i,j);
            WorldGen.GetTreeBottom(i, j, out var x, out var y);
            TreeTypes treeType = WorldGen.GetTreeType(Main.tile[x, y].TileType);
            if (treeType == TreeTypes.None)// || Main.rand.NextBool(10)
                return;
            y--;
            while (y > 10 && Main.tile[x, y].HasTile && TileID.Sets.IsShakeable[Main.tile[x, y].TileType])
            {
                y--;
            }
            y++;
            if (!WorldGen.IsTileALeafyTreeTop(x, y) || Collision.SolidTiles(x - 2, x + 2, y - 2, y + 2))
                return;
			Item.NewItem(null, new Vector2(x,y), ItemType<Strawberry>());
        }
	}
}