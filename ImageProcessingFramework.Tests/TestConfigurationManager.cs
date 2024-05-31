using System.Collections.Generic;
using System.IO;
using Xunit;
using ImageProcessingFramework.Services;
using ImageProcessingFramework.Models;

namespace ImageProcessingFramework.Tests
{
	public class TestConfigurationManager
	{
		[Fact]
		public void TestLoadConfiguration()
		{
			// Arrange
			var configManager = new ConfigurationManager();
			string configJson = "[{\"PluginName\":\"ResizeEffect\",\"Parameters\":{\"size\":\"100\"}},{\"PluginName\":\"BlurEffect\",\"Parameters\":{\"radius\":\"2\"}}]";
			File.WriteAllText("testConfig.json", configJson);

			// Act
			var configs = configManager.LoadConfiguration("testConfig.json");

			// Assert
			Assert.Equal(2, configs.Count);
			Assert.Equal("ResizeEffect", configs[0].PluginName);
			Assert.Equal("100", configs[0].Parameters["size"]);
			Assert.Equal("BlurEffect", configs[1].PluginName);
			Assert.Equal("2", configs[1].Parameters["radius"]);

			// Clean up
			File.Delete("testConfig.json");
		}
	}
}
