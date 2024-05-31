using System.Collections.Generic;
using System.IO;
using ImageProcessingFramework.Models;
using Newtonsoft.Json;

namespace ImageProcessingFramework.Services
{
	public class ConfigurationManager
	{
		public List<PluginConfiguration> LoadConfiguration(string configFilePath)
		{
			string configJson = File.ReadAllText(configFilePath);
			var pluginConfigurations = JsonConvert.DeserializeObject<List<PluginConfiguration>>(configJson);
			return pluginConfigurations;
		}
	}
}
