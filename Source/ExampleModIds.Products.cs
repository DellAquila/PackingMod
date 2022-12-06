using Mafi.Base;
using ProductID = Mafi.Core.Products.ProductProto.ID;

namespace PackingMod;

// Tip: Keep all IDs as static members of a class like this. See `Mafi.Base.Ids`
public static partial class PackingModIds {

	// Products proto registrations can be done either by manually constructing and registering
	// `ProductProto` variants or by defining IDs and marking them with one of following attributes:
	// CountableProduct, FluidProduct, LooseProduct, MoltenProduct, or VirtualProduct.
	// These static IDs are then automatically registered via `registrator.RegisterAllProducts()`.
	public static partial class Products {

		// [CountableProduct(icon: Assets.Base.Products.Icons.Wood_svg,
		// 	prefab: Assets.Base.Products.Countable.RawWood_prefab)]
		// public static readonly ProductID ExampleUnitProduct = Ids.Products.CreateId("ExampleUnitProduct");

		// [FluidProduct(color: 0xFF00FF, icon: Assets.Base.Products.Icons.Water_svg)]
		// public static readonly ProductID ExampleFluidProduct = Ids.Products.CreateId("ExampleFluidProduct");



		// Looose


		[LooseProduct(material: Assets.Base.Products.Loose.AnimalFeed_mat,
			icon: Assets.Base.Products.Icons.AnimalFood_svg)]
		public static readonly ProductID AnimalFeedCompressed = Ids.Products.CreateId("AnimalFeedCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.Biomass_mat,
			icon: Assets.Base.Products.Icons.Biomass_svg)]
		public static readonly ProductID BiomassCompressed = Ids.Products.CreateId("BiomassCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.Canola_mat,
			icon: Assets.Base.Products.Icons.Canola_svg)]
		public static readonly ProductID CanolaCompressed = Ids.Products.CreateId("CanolaCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.Coal_mat,
			icon: Assets.Base.Products.Icons.Coal_svg)]
		public static readonly ProductID CoalCompressed = Ids.Products.CreateId("CoalCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.Compost_mat,
			icon: Assets.Base.Products.Icons.Digestate_svg)]
		public static readonly ProductID CompostCompressed = Ids.Products.CreateId("CompostCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.CopperOreCrushed_mat,
			icon: Assets.Base.Products.Icons.CopperCrushed_svg)]
		public static readonly ProductID CopperOreCrushedCompressed = Ids.Products.CreateId("CopperOreCrushedCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.CopperOre_mat,
			icon: Assets.Base.Products.Icons.CopperOre_svg)]
		public static readonly ProductID CopperOreCompressed = Ids.Products.CreateId("CopperOreCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.Corn_mat,
			icon: Assets.Base.Products.Icons.Corn_svg)]
		public static readonly ProductID CornCompressed = Ids.Products.CreateId("CornCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.FilterMedia_mat,
			icon: Assets.Base.Products.Icons.FilterMedia_svg)]
		public static readonly ProductID FilterMediaCompressed = Ids.Products.CreateId("FilterMediaCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.GlassMix_mat,
			icon: Assets.Base.Products.Icons.GlassMix_svg)]
		public static readonly ProductID GlassMixCompressed = Ids.Products.CreateId("GlassMixCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.GoldOreCrushed_mat,
			icon: Assets.Base.Products.Icons.GoldOreCrushed_svg)]
		public static readonly ProductID GoldOreCrushedCompressed = Ids.Products.CreateId("GoldOreCrushedCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.GoldOrePowder_mat,
			icon: Assets.Base.Products.Icons.GoldOrePowder_svg)]
		public static readonly ProductID GoldOrePowderCompressed = Ids.Products.CreateId("GoldOrePowderCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.GoldOre_mat,
			icon: Assets.Base.Products.Icons.GoldOre_svg)]
		public static readonly ProductID GoldOreCompressed = Ids.Products.CreateId("GoldOreCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.Gravel_mat,
			icon: Assets.Base.Products.Icons.Gravel_svg)]
		public static readonly ProductID GravelCompressed = Ids.Products.CreateId("GravelCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.IronOreCrushed_mat,
			icon: Assets.Base.Products.Icons.IronCrushed_svg)]
		public static readonly ProductID IronOreCrushedCompressed = Ids.Products.CreateId("IronOreCrushedCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.IronOre_mat,
			icon: Assets.Base.Products.Icons.IronOre_svg)]
		public static readonly ProductID IronOreCompressed = Ids.Products.CreateId("IronOreCompressed");


		[LooseProduct(material: Assets.Base.Products.Loose.Limestone_mat,
			icon: Assets.Base.Products.Icons.Limestone_svg)]
		public static readonly ProductID LimestoneCompressed = Ids.Products.CreateId("LimestoneCompressed");


		[LooseProduct(material: Assets.Base.Products.Loose.MeatTrimmings_mat,
			icon: Assets.Base.Products.Icons.MeatTrimmings_svg)]
		public static readonly ProductID MeatTrimmingsCompressed = Ids.Products.CreateId("MeatTrimmingsCompressed");


		[LooseProduct(material: Assets.Base.Products.Loose.Poppy_mat,
			icon: Assets.Base.Products.Icons.Poppy_svg)]
		public static readonly ProductID PoppyCompressed = Ids.Products.CreateId("PoppyCompressed");


		[LooseProduct(material: Assets.Base.Products.Loose.Potato_mat,
			icon: Assets.Base.Products.Icons.Potato128_png)]
		public static readonly ProductID PotatoCompressed = Ids.Products.CreateId("PotatoCompressed");


		[LooseProduct(material: Assets.Base.Products.Loose.Quartz_mat,
			icon: Assets.Base.Products.Icons.Quartz_svg)]
		public static readonly ProductID QuartzCompressed = Ids.Products.CreateId("QuartzCompressed");


		[LooseProduct(material: Assets.Base.Products.Loose.Rock_mat,
			icon: Assets.Base.Products.Icons.Rock_svg)]
		public static readonly ProductID RockCompressed = Ids.Products.CreateId("RockCompressed");


		[LooseProduct(material: Assets.Base.Products.Loose.Salt_mat,
			icon: Assets.Base.Products.Icons.Salt_svg)]
		public static readonly ProductID SaltCompressed = Ids.Products.CreateId("SaltCompressed");


		[LooseProduct(material: Assets.Base.Products.Loose.Sand_mat,
			icon: Assets.Base.Products.Icons.Sand_svg)]
		public static readonly ProductID SandCompressed = Ids.Products.CreateId("SandCompressed");


		[LooseProduct(material: Assets.Base.Products.Loose.SlagCrushed_mat,
			icon: Assets.Base.Products.Icons.SlagCrushed_svg)]
		public static readonly ProductID SlagCrushedCompressed = Ids.Products.CreateId("SlagCrushedCompressed");



		[LooseProduct(material: Assets.Base.Products.Loose.Slag_mat,
			icon: Assets.Base.Products.Icons.Slag_svg)]
		public static readonly ProductID SlagCompressed = Ids.Products.CreateId("SlagCompressed");



		[LooseProduct(material: Assets.Base.Products.Loose.Sludge_mat,
			icon: Assets.Base.Products.Icons.Sludge_svg)]
		public static readonly ProductID SludgeCompressed = Ids.Products.CreateId("SludgeCompressed");



		[LooseProduct(material: Assets.Base.Products.Loose.SoyBeans_mat,
			icon: Assets.Base.Products.Icons.Soybean_svg)]
		public static readonly ProductID SoyBeansCompressed = Ids.Products.CreateId("SoyBeansCompressed");



		[LooseProduct(material: Assets.Base.Products.Loose.Sugarcane_mat,
			icon: Assets.Base.Products.Icons.SugarCane_svg)]
		public static readonly ProductID SugarcaneCompressed = Ids.Products.CreateId("SugarcaneCompressed");


		[LooseProduct(material: Assets.Base.Products.Loose.Sugar_mat,
			icon: Assets.Base.Products.Icons.Sugar_svg)]
		public static readonly ProductID SugarCompressed = Ids.Products.CreateId("SugarCompressed");


		[LooseProduct(material: Assets.Base.Products.Loose.Sulfur_mat,
			icon: Assets.Base.Products.Icons.Sulfur_svg)]
		public static readonly ProductID SulfurCompressed = Ids.Products.CreateId("SulfurCompressed");



		[LooseProduct(material: Assets.Base.Products.Loose.UraniumOreCrushed_mat,
			icon: Assets.Base.Products.Icons.UraniumOreCrushed_svg)]
		public static readonly ProductID UraniumOreCrushedCompressed = Ids.Products.CreateId("UraniumOreCrushedCompressed");



		[LooseProduct(material: Assets.Base.Products.Loose.UraniumOre_mat,
			icon: Assets.Base.Products.Icons.UraniumOre_svg)]
		public static readonly ProductID UraniumOreCompressed = Ids.Products.CreateId("UraniumOreCompressed");



		[LooseProduct(material: Assets.Base.Products.Loose.Wheat_mat,
			icon: Assets.Base.Products.Icons.Wheat_svg)]
		public static readonly ProductID WheatCompressed = Ids.Products.CreateId("WheatCompressed");



		[LooseProduct(material: Assets.Base.Products.Loose.Yellowcake_mat,
			icon: Assets.Base.Products.Icons.YellowCake_svg)]
		public static readonly ProductID YellowcakeCompressed = Ids.Products.CreateId("YellowcakeCompressed");

		[LooseProduct(material: Assets.Base.Products.Loose.Landfill_mat,
			icon: Assets.Base.Products.Icons.Waste_svg)]
		public static readonly ProductID WasteCompressed = Ids.Products.CreateId("WasteCompressed");










		[MoltenProduct(material: Assets.Base.Products.Molten.Copper_mat,
			prefab: Assets.Base.Products.Molten.MoltenCopper_prefab,
			icon: Assets.Base.Products.Icons.CopperMolten_svg)]
		public static readonly ProductID ExampleMoltenProduct = Ids.Products.CreateId("ExampleMoltenProduct");

	}

}