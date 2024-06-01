using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

public class NewRecipes : ModSystem
{
	public static RecipeGroup SilverBarRecipeGroup;
	public static RecipeGroup CopperBarRecipeGroup;
	public static RecipeGroup EvilSkinRecipeGroup;
	public static RecipeGroup EvilBarRecipeGroup;
	public static RecipeGroup GoldBarRecipeGroup;

	public override void Unload()
	{
		SilverBarRecipeGroup = null;
		CopperBarRecipeGroup = null;
		EvilSkinRecipeGroup = null;
		EvilBarRecipeGroup = null;
		GoldBarRecipeGroup = null;
	}

	public override void AddRecipeGroups()
	{
		SilverBarRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.SilverBar)}",
													 ItemID.SilverBar, ItemID.TungstenBar);
		RecipeGroup.RegisterGroup("LimitedResourcesRecipes:SilverBar", SilverBarRecipeGroup);

		CopperBarRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CopperBar)}",
													 ItemID.CopperBar, ItemID.TinBar);
		RecipeGroup.RegisterGroup("LimitedResourcesRecipes:CopperBar", CopperBarRecipeGroup);

		EvilSkinRecipeGroup = new RecipeGroup(() => $"{Lang.GetItemNameValue(ItemID.ShadowScale)}/{Lang.GetItemNameValue(ItemID.TissueSample)}",
													ItemID.ShadowScale, ItemID.TissueSample);
		RecipeGroup.RegisterGroup("LimitedResourcesRecipes:EvilSkin", EvilSkinRecipeGroup);

		EvilBarRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CrimtaneBar)}",
												   ItemID.DemoniteBar, ItemID.CrimtaneBar);
		RecipeGroup.RegisterGroup("LimitedResourcesRecipes:EvilBar", EvilBarRecipeGroup);

		GoldBarRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldBar)}",
												   ItemID.GoldBar, ItemID.PlatinumBar);
		RecipeGroup.RegisterGroup("LimitedResourcesRecipes:EvilBar", GoldBarRecipeGroup);
	}

	public override void AddRecipes()
	{
		Recipe.Create(ItemID.Mace)
		      .AddIngredient(ItemID.Wood, 400)
			  .AddIngredient(ItemID.StoneBlock, 800)
			  .AddRecipeGroup(CopperBarRecipeGroup, 50)
			  .AddTile(TileID.Anvils)
			  .Register();

		Recipe.Create(ItemID.BandofRegeneration)
			  .AddIngredient(ItemID.SoulofLight, 300)
			  .AddRecipeGroup(CopperBarRecipeGroup, 200)
			  .AddTile(TileID.Anvils)
			  .Register();

		Recipe.Create(ItemID.ShoeSpikes)
			  .AddIngredient(ItemID.Ectoplasm, 120)
			  .AddRecipeGroup(RecipeGroupID.IronBar, 180)
			  .AddTile(TileID.MythrilAnvil)
			  .Register();

		Recipe.Create(ItemID.IceMirror)
			  .AddIngredient(ItemID.ManaCrystal, 15)
			  .AddIngredient(ItemID.SoulofNight, 120)
			  .AddIngredient(ItemID.SoulofLight, 120)
			  .AddRecipeGroup(SilverBarRecipeGroup, 150)
			  .AddTile(TileID.IceMachine)
			  .Register();

		Recipe.Create(ItemID.CloudinaBottle)
			  .AddIngredient(ItemID.Cloud, 10)
			  .AddIngredient(ItemID.Bottle)
			  .AddRecipeGroup(EvilBarRecipeGroup, 400)
			  .AddIngredient(ItemID.Gel, 500)
			  .AddTile(TileID.WorkBenches)
			  .Register();

		Recipe.Create(ItemID.FlyingCarpet)
			  .AddIngredient(ItemID.Bone, 400)
			  .AddIngredient(ItemID.Silk, 200)
			  .AddIngredient(ItemID.ManaCrystal, 20)
			  .AddTile(TileID.Loom)
			  .Register();

		Recipe.Create(ItemID.BabyBirdStaff)
			  .AddRecipeGroup(RecipeGroupID.Wood, 1000)
			  .AddRecipeGroup(EvilSkinRecipeGroup, 300)
			  .AddRecipeGroup(RecipeGroupID.Birds, 10)
			  .AddTile(TileID.DemonAltar)
			  .Register();

		Recipe.Create(ItemID.EncumberingStone)
			  .AddRecipeGroup(EvilBarRecipeGroup, 200)
			  .AddRecipeGroup(RecipeGroupID.Sand, 300)
			  .AddRecipeGroup(RecipeGroupID.IronBar, 100)
			  .AddTile(TileID.Hellforge)
			  .Register();

		Recipe.Create(ItemID.Terragrim)
			  .AddIngredient(ItemID.EnchantedSword, 10)
			  .AddTile(TileID.Anvils)
			  .Register();

		Recipe.Create(ItemID.WaterBolt)
			  .AddIngredient(ItemID.BottledWater, 200)
			  .AddIngredient(ItemID.Book, 30)
			  .AddIngredient(ItemID.ManaCrystal, 10)
			  .AddIngredient(ItemID.Bone, 150)
			  .AddTile(TileID.Bookcases)
			  .Register();

		Recipe.Create(ItemID.Blowpipe)
			  .AddIngredient(ItemID.BambooBlock, 320)
			  .AddIngredient(ItemID.Rope, 480)
			  .AddRecipeGroup(RecipeGroupID.IronBar, 40)
			  .AddTile(TileID.WorkBenches)
			  .Register();

        Recipe.Create(ItemID.StormTigerStaff)
              .AddIngredient(ItemID.DungeonDesertKey, 3)
              .AddIngredient(ItemID.SoulofFright, 180)
              .AddIngredient(ItemID.AntlionMandible, 25)
              .AddRecipeGroup(GoldBarRecipeGroup, 150)
              .AddTile(TileID.DemonAltar)
              .Register();

        Recipe.Create(ItemID.StaffoftheFrostHydra)
              .AddIngredient(ItemID.FrozenKey, 3)
              .AddIngredient(ItemID.SoulofMight, 180)
              .AddIngredient(ItemID.IceBlock, 1200)
              .AddIngredient(ItemID.FlinxFur, 15)
              .AddTile(TileID.DemonAltar)
              .Register();

        Recipe.Create(ItemID.RainbowGun)
              .AddIngredient(ItemID.HallowedKey, 3)
              .AddIngredient(ItemID.RainbowBrick, 300)
              .AddIngredient(ItemID.PixieDust, 150)
              .AddRecipeGroup(GoldBarRecipeGroup, 150)
              .AddTile(TileID.MythrilAnvil)
              .Register();

        Recipe.Create(ItemID.PiranhaGun)
              .AddIngredient(ItemID.JungleKey, 3)
              .AddIngredient(ItemID.SoulofSight, 180)
              .AddIngredient(ItemID.Bass, 30)
              .AddRecipeGroup(RecipeGroupID.IronBar, 300)
              .AddTile(TileID.MythrilAnvil)
              .Register();

        Recipe.Create(ItemID.ScourgeoftheCorruptor)
              .AddIngredient(ItemID.CorruptionKey, 3)
              .AddIngredient(ItemID.EbonstoneBlock, 1000)
              .AddIngredient(ItemID.ShadowScale, 200)
              .AddIngredient(ItemID.HallowedBar, 100)
              .AddTile(TileID.DemonAltar)
              .Register();

        Recipe.Create(ItemID.VampireKnives)
              .AddIngredient(ItemID.CrimsonKey, 3)
              .AddIngredient(ItemID.CrimstoneBlock, 1000)
              .AddIngredient(ItemID.TissueSample, 200)
              .AddIngredient(ItemID.HallowedBar, 100)
              .AddTile(TileID.MythrilAnvil)
              .Register();
    }
}
