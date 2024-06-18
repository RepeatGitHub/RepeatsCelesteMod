using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using RepeatsCelesteMod.Content.Items.Materials;
using Terraria;
using Terraria.DataStructures;
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

    public class MadelinePlayer : ModPlayer
	{
		public bool nameLmao1(string namer1)
		{
			return Player.name == namer1;
		}
		public bool nameLmao2(string namer1,string namer2)
		{
			return Player.name == namer1 || Player.name == namer2;
		}
		public bool nameLmao3(string namer1,string namer2,string namer3)
		{
			return Player.name == namer1 || Player.name == namer2 || Player.name == namer3;
		}
		public bool nameLmao5(string namer1,string namer2,string namer3,string namer4,string namer5)
		{
			return Player.name == namer1 || Player.name == namer2 || Player.name == namer3 || Player.name == namer4 || Player.name == namer5;
		}
		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
        {
            static Item createItem(int type,int amt)
            {
                Item i = new Item();
                i.SetDefaults(type);
				i.stack=amt;
                return i;
    	    }

            if (!mediumCoreDeath) {
				if (nameLmao2("Topaz","Repeat")) {
					yield return createItem(ItemID.IronBar,13);
					yield return createItem(ItemID.GreenThread,3);
				}
				if (nameLmao2("Madeline","Maddy")) {
					yield return createItem(ModContent.ItemType<Content.Items.FlyingStrawberry.FlyingStrawberry>(),1);
				}
				if (nameLmao2("Theo","Alex")) {
					yield return createItem(ItemID.GrapplingHook,1);
				}
            }
        }
	}
}