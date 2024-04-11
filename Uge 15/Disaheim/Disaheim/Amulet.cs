using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
	public enum Level
	{
		medium,
		high,
		low
	}
	public class Amulet : Merchandise
	{
		public string Design { get; set; }
		public Level Quality { get; set; }

		public Amulet(string itemId) : base(itemId)
		{
			ItemId = itemId;
		}
		public Amulet(string itemId, Level quality) : base(itemId)
		{
			ItemId = itemId;
			Quality = quality;
		}
		public Amulet(string itemId, Level quality, string design) : base(itemId)
		{
			ItemId = itemId;
			Quality = quality;
			Design = design;
		}
		public override string ToString()
		{
			return "ItemId: "+ItemId+", Quality: "+Quality+ ", Design: "+Design;
		}
	}
}
