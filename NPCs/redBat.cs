using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CaveStory.NPCs
{
	public class RedBat : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Red Bat";
			npc.displayName = "Red Bat";
			npc.aiStyle = 14;//-1;
			npc.lifeMax = 350;
			npc.damage = 60;
			npc.defense = 15;
			npc.knockBackResist = 0f;
			npc.dontTakeDamage = false;
			//npc.width = 15;
			//npc.height = 18;
			npc.width = 22;
			npc.height = 18;
			Main.npcFrameCount[npc.type] = 6;
			npc.value = Item.buyPrice(0, 0, 30, 0);
			npc.npcSlots = .5f;
			npc.scale = 2f;
			npc.boss = false;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = false;
			npc.soundHit = mod.GetSoundSlot(SoundType.NPCHit, "Sounds/NPCHit/EnemyHurtSqueak");
			//npc.soundKilled = mod.GetSoundSlot(SoundType.NPCKilled, "Sounds/NPCKilled/???");
			bannerItem = mod.ItemType("RedBatBanner");
			banner = npc.type;
			animationType = NPCID.CaveBat;
		}

		public override float CanSpawn(NPCSpawnInfo spawnInfo)
		{
			//Tile tile = Main.tile[spawnInfo.spawnTileX, spawnInfo.spawnTileY];
			return 1f;
			//return spawnInfo.spawnTileY > Main.maxTilesY - 190 ? 100f : 0f;
		}
	}
}
