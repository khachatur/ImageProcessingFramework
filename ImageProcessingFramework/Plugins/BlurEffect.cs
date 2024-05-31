using System;
using ImageProcessingFramework.Interfaces;
using ImageProcessingFramework.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ImageProcessingFramework.Plugins
{
	public class BlurEffect : IPlugin
	{
		public void ApplyEffect(ImageData image, EffectParameters parameters)
		{
			// Dummy implementation for blurring
			Console.WriteLine($"Applying blur with radius {parameters.Parameters["radius"]}.");
		}
	}
}
