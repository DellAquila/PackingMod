using Mafi;
using Mafi.Base;
using Mafi.Core.Entities.Animations;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Mods;

namespace PackingMod;

internal class ExampleMachineData : IModData {

	public void RegisterData(ProtoRegistrator registrator) {
		registrator.MachineProtoBuilder
			.Start("Packager", PackingModIds.Machines.Packager)
			.Description("Compress or decompress items using the packager.")
			.SetCost(Costs.Build.CP(10).Workers(0))
			// For examples of layouts see `Mafi.Base.BaseMod` and `EntityLayoutParser`.
			.SetLayout(new EntityLayoutParams(useNewLayoutSyntax: true),
				"A~>[1]>~E",
				"B'>[1]>'F",
				"C#>[1]>#G",
				"D@>[1]>@H")
			.SetCategories(Ids.ToolbarCategories.MachinesMetallurgy)
			.SetCustomIconPath(Assets.Base.Icons.Technologies.CustomRoutes_svg)
			.SetPrefabPath("Assets/PackingMod/BlastFurnace.prefab")
		//	.SetAnimationParams(
		//		animParams: AnimationParams.RepeatTimes(Duration.FromKeyframes(360),
		//		times: 2,
		//		changeSpeedToFit: true))
			.BuildAndAdd();


		// registrator.RecipeProtoBuilder .Start(name: "Compress Coal", recipeId: PackingModIds.Recipes.Packing_1, machineId: PackingModIds.Machines.Packager) .AddOutput(1, PackingModIds.Products.CoalCompressed)			.AddInput(50, Ids.Products.Coal)			.SetDuration(6.Seconds())			.BuildAndAdd();

		registrator.RecipeProtoBuilder.Start(name: "Compress AnimalFeed", recipeId: PackingModIds.Recipes.Packing_1, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.AnimalFeedCompressed).AddInput(50, Ids.Products.AnimalFeed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Biomass", recipeId: PackingModIds.Recipes.Packing_2, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.BiomassCompressed).AddInput(50, Ids.Products.Biomass).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Canola", recipeId: PackingModIds.Recipes.Packing_3, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.CanolaCompressed).AddInput(50, Ids.Products.Canola).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Coal", recipeId: PackingModIds.Recipes.Packing_4, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.CoalCompressed).AddInput(50, Ids.Products.Coal).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Compost", recipeId: PackingModIds.Recipes.Packing_5, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.CompostCompressed).AddInput(50, Ids.Products.Compost).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress CopperOreCrushed", recipeId: PackingModIds.Recipes.Packing_6, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.CopperOreCrushedCompressed).AddInput(50, Ids.Products.CopperOreCrushed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress CopperOre", recipeId: PackingModIds.Recipes.Packing_7, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.CopperOreCompressed).AddInput(50, Ids.Products.CopperOre).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Corn", recipeId: PackingModIds.Recipes.Packing_8, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.CornCompressed).AddInput(50, Ids.Products.Corn).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress FilterMedia", recipeId: PackingModIds.Recipes.Packing_9, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.FilterMediaCompressed).AddInput(50, Ids.Products.FilterMedia).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress GlassMix", recipeId: PackingModIds.Recipes.Packing_10, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.GlassMixCompressed).AddInput(50, Ids.Products.GlassMix).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress GoldOreCrushed", recipeId: PackingModIds.Recipes.Packing_11, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.GoldOreCrushedCompressed).AddInput(50, Ids.Products.GoldOreCrushed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress GoldOrePowder", recipeId: PackingModIds.Recipes.Packing_12, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.GoldOrePowderCompressed).AddInput(50, Ids.Products.GoldOrePowder).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress GoldOre", recipeId: PackingModIds.Recipes.Packing_13, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.GoldOreCompressed).AddInput(50, Ids.Products.GoldOre).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Gravel", recipeId: PackingModIds.Recipes.Packing_14, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.GravelCompressed).AddInput(50, Ids.Products.Gravel).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress IronOreCrushed", recipeId: PackingModIds.Recipes.Packing_15, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.IronOreCrushedCompressed).AddInput(50, Ids.Products.IronOreCrushed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress IronOre", recipeId: PackingModIds.Recipes.Packing_16, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.IronOreCompressed).AddInput(50, Ids.Products.IronOre).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Limestone", recipeId: PackingModIds.Recipes.Packing_17, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.LimestoneCompressed).AddInput(50, Ids.Products.Limestone).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress MeatTrimmings", recipeId: PackingModIds.Recipes.Packing_18, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.MeatTrimmingsCompressed).AddInput(50, Ids.Products.MeatTrimmings).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Poppy", recipeId: PackingModIds.Recipes.Packing_19, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.PoppyCompressed).AddInput(50, Ids.Products.Poppy).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Potato", recipeId: PackingModIds.Recipes.Packing_20, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.PotatoCompressed).AddInput(50, Ids.Products.Potato).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Quartz", recipeId: PackingModIds.Recipes.Packing_21, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.QuartzCompressed).AddInput(50, Ids.Products.Quartz).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Rock", recipeId: PackingModIds.Recipes.Packing_22, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.RockCompressed).AddInput(50, Ids.Products.Rock).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Salt", recipeId: PackingModIds.Recipes.Packing_23, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.SaltCompressed).AddInput(50, Ids.Products.Salt).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Sand", recipeId: PackingModIds.Recipes.Packing_24, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.SandCompressed).AddInput(50, Ids.Products.Sand).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress SlagCrushed", recipeId: PackingModIds.Recipes.Packing_25, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.SlagCrushedCompressed).AddInput(50, Ids.Products.SlagCrushed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Slag", recipeId: PackingModIds.Recipes.Packing_26, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.SlagCompressed).AddInput(50, Ids.Products.Slag).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Sludge", recipeId: PackingModIds.Recipes.Packing_27, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.SludgeCompressed).AddInput(50, Ids.Products.Sludge).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress SoyBeans", recipeId: PackingModIds.Recipes.Packing_28, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.SoyBeansCompressed).AddInput(50, Ids.Products.Soybean).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Sugarcane", recipeId: PackingModIds.Recipes.Packing_29, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.SugarcaneCompressed).AddInput(50, Ids.Products.SugarCane).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Sugar", recipeId: PackingModIds.Recipes.Packing_30, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.SugarCompressed).AddInput(50, Ids.Products.Sugar).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Sulfur", recipeId: PackingModIds.Recipes.Packing_31, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.SulfurCompressed).AddInput(50, Ids.Products.Sulfur).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress UraniumOreCrushed", recipeId: PackingModIds.Recipes.Packing_32, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.UraniumOreCrushedCompressed).AddInput(50, Ids.Products.UraniumOreCrushed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress UraniumOre", recipeId: PackingModIds.Recipes.Packing_33, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.UraniumOreCompressed).AddInput(50, Ids.Products.UraniumOre).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Wheat", recipeId: PackingModIds.Recipes.Packing_34, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.WheatCompressed).AddInput(50, Ids.Products.Wheat).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Yellowcake", recipeId: PackingModIds.Recipes.Packing_35, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.YellowcakeCompressed).AddInput(50, Ids.Products.YellowCake).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Compress Waste", recipeId: PackingModIds.Recipes.Packing_36, machineId: PackingModIds.Machines.Packager).AddOutput(1, PackingModIds.Products.WasteCompressed).AddInput(50, Ids.Products.Waste).SetDuration(6.Seconds()).BuildAndAdd();

		registrator.RecipeProtoBuilder.Start(name: "Decompress AnimalFeed", recipeId: PackingModIds.Recipes.Packing_38, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.AnimalFeedCompressed).AddOutput(50, Ids.Products.AnimalFeed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Biomass", recipeId: PackingModIds.Recipes.Packing_39, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.BiomassCompressed).AddOutput(50, Ids.Products.Biomass).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Canola", recipeId: PackingModIds.Recipes.Packing_40, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.CanolaCompressed).AddOutput(50, Ids.Products.Canola).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Coal", recipeId: PackingModIds.Recipes.Packing_41, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.CoalCompressed).AddOutput(50, Ids.Products.Coal).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Compost", recipeId: PackingModIds.Recipes.Packing_42, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.CompostCompressed).AddOutput(50, Ids.Products.Compost).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress CopperOreCrushed", recipeId: PackingModIds.Recipes.Packing_43, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.CopperOreCrushedCompressed).AddOutput(50, Ids.Products.CopperOreCrushed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress CopperOre", recipeId: PackingModIds.Recipes.Packing_44, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.CopperOreCompressed).AddOutput(50, Ids.Products.CopperOre).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Corn", recipeId: PackingModIds.Recipes.Packing_45, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.CornCompressed).AddOutput(50, Ids.Products.Corn).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress FilterMedia", recipeId: PackingModIds.Recipes.Packing_46, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.FilterMediaCompressed).AddOutput(50, Ids.Products.FilterMedia).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress GlassMix", recipeId: PackingModIds.Recipes.Packing_47, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.GlassMixCompressed).AddOutput(50, Ids.Products.GlassMix).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress GoldOreCrushed", recipeId: PackingModIds.Recipes.Packing_48, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.GoldOreCrushedCompressed).AddOutput(50, Ids.Products.GoldOreCrushed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress GoldOrePowder", recipeId: PackingModIds.Recipes.Packing_49, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.GoldOrePowderCompressed).AddOutput(50, Ids.Products.GoldOrePowder).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress GoldOre", recipeId: PackingModIds.Recipes.Packing_50, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.GoldOreCompressed).AddOutput(50, Ids.Products.GoldOre).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Gravel", recipeId: PackingModIds.Recipes.Packing_51, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.GravelCompressed).AddOutput(50, Ids.Products.Gravel).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress IronOreCrushed", recipeId: PackingModIds.Recipes.Packing_52, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.IronOreCrushedCompressed).AddOutput(50, Ids.Products.IronOreCrushed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress IronOre", recipeId: PackingModIds.Recipes.Packing_53, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.IronOreCompressed).AddOutput(50, Ids.Products.IronOre).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Limestone", recipeId: PackingModIds.Recipes.Packing_54, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.LimestoneCompressed).AddOutput(50, Ids.Products.Limestone).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress MeatTrimmings", recipeId: PackingModIds.Recipes.Packing_55, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.MeatTrimmingsCompressed).AddOutput(50, Ids.Products.MeatTrimmings).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Poppy", recipeId: PackingModIds.Recipes.Packing_56, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.PoppyCompressed).AddOutput(50, Ids.Products.Poppy).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Potato", recipeId: PackingModIds.Recipes.Packing_57, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.PotatoCompressed).AddOutput(50, Ids.Products.Potato).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Quartz", recipeId: PackingModIds.Recipes.Packing_58, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.QuartzCompressed).AddOutput(50, Ids.Products.Quartz).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Rock", recipeId: PackingModIds.Recipes.Packing_59, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.RockCompressed).AddOutput(50, Ids.Products.Rock).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Salt", recipeId: PackingModIds.Recipes.Packing_60, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.SaltCompressed).AddOutput(50, Ids.Products.Salt).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Sand", recipeId: PackingModIds.Recipes.Packing_61, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.SandCompressed).AddOutput(50, Ids.Products.Sand).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress SlagCrushed", recipeId: PackingModIds.Recipes.Packing_62, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.SlagCrushedCompressed).AddOutput(50, Ids.Products.SlagCrushed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Slag", recipeId: PackingModIds.Recipes.Packing_63, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.SlagCompressed).AddOutput(50, Ids.Products.Slag).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Sludge", recipeId: PackingModIds.Recipes.Packing_64, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.SludgeCompressed).AddOutput(50, Ids.Products.Sludge).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress SoyBeans", recipeId: PackingModIds.Recipes.Packing_65, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.SoyBeansCompressed).AddOutput(50, Ids.Products.Soybean).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Sugarcane", recipeId: PackingModIds.Recipes.Packing_66, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.SugarcaneCompressed).AddOutput(50, Ids.Products.SugarCane).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Sugar", recipeId: PackingModIds.Recipes.Packing_67, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.SugarCompressed).AddOutput(50, Ids.Products.Sugar).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Sulfur", recipeId: PackingModIds.Recipes.Packing_68, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.SulfurCompressed).AddOutput(50, Ids.Products.Sulfur).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress UraniumOreCrushed", recipeId: PackingModIds.Recipes.Packing_69, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.UraniumOreCrushedCompressed).AddOutput(50, Ids.Products.UraniumOreCrushed).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress UraniumOre", recipeId: PackingModIds.Recipes.Packing_70, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.UraniumOreCompressed).AddOutput(50, Ids.Products.UraniumOre).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Wheat", recipeId: PackingModIds.Recipes.Packing_71, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.WheatCompressed).AddOutput(50, Ids.Products.Wheat).SetDuration(6.Seconds()).BuildAndAdd();
		registrator.RecipeProtoBuilder.Start(name: "Decompress Yellowcake", recipeId: PackingModIds.Recipes.Packing_72, machineId: PackingModIds.Machines.Packager).AddInput(1, PackingModIds.Products.YellowcakeCompressed).AddOutput(50, Ids.Products.YellowCake).SetDuration(6.Seconds()).BuildAndAdd();





	}
}