using System.Collections.Generic;
using Xunit;
using ImageProcessingFramework.Services;
using ImageProcessingFramework.Models;
using ImageProcessingFramework.Plugins;
using ImageProcessingFramework.Interfaces;

namespace ImageProcessingFramework.Tests
{
	public class TestImageProcessor
	{
		[Fact]
		public void TestAddImageTaskAndProcessImages()
		{
			// Arrange
			var imageProcessor = new ImageProcessor();
			var imageTask = new ImageTask
			{
				Image = new ImageData(), // Dummy image object
				Plugins = new List<IPlugin> { new ResizeEffect(), new BlurEffect() },
				EffectParameters = new List<EffectParameters>
				{
					new EffectParameters { Parameters = new Dictionary<string, object> { { "size", 100 } } },
					new EffectParameters { Parameters = new Dictionary<string, object> { { "radius", 2 } } }
				}
			};

			// Act
			imageProcessor.AddImageTask(imageTask);
			imageProcessor.ProcessImages();

			// Assert
			Assert.Single(imageProcessor.GetImageTasks());
		}
	}
}
