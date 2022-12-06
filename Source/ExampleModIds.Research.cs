using Mafi.Base;
using Mafi.Core.Research;
using ResNodeID = Mafi.Core.Research.ResearchNodeProto.ID;

namespace PackingMod;

public partial class PackingModIds {

	public partial class Research {

		[ResearchCosts(difficulty: 1)]
		public static readonly ResNodeID UnlockPackingModStuff = Ids.Research.CreateId("UnlockPackingModStuff");

	}

}