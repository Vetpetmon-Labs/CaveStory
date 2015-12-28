
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CaveStory.Items
{
	public class Chinfish : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Chinfish";
			item.questItem = true;
			item.maxStack = 1;
			item.width = 26;
			item.height = 26;
			item.uniqueStack = true;
			item.rare = -11;
		}

		public override bool IsQuestFish()
		{
			return true;
		}

		public override bool IsAnglerQuestAvailable()
		{
			return Main.hardMode;
		}

		public override void AnglerQuestChat(ref string description, ref string catchLocation)
		{
			description = "Kanpachi told me about the Chinfish- the one and only one. I'd like to have it on my wall! You got the message- go fish me that Chinfish!";
			catchLocation = "\n(Caught Underground.)";
		}
	}
}
