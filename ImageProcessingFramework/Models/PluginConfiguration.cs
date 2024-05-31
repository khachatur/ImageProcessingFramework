using System.Collections.Generic;

namespace ImageProcessingFramework.Models
{
	public class PluginConfiguration
	{
		public string PluginName { get; set; }
		public Dictionary<string, string> Parameters { get; set; }
	}
}
