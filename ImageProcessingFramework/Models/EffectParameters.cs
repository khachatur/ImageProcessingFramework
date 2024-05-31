using System.Collections.Generic;

namespace ImageProcessingFramework.Models
{
	public class EffectParameters
	{
		public Dictionary<string, object> Parameters { get; set; }

		public EffectParameters()
		{
			Parameters = new Dictionary<string, object>();
		}
	}
}
