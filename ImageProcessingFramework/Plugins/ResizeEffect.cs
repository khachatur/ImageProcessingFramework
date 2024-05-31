using System;
using ImageProcessingFramework.Interfaces;
using ImageProcessingFramework.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ImageProcessingFramework.Plugins
{
	public class ResizeEffect : IPlugin
	{
		public void ApplyEffect(ImageData image, EffectParameters parameters)
		{
			// Dummy implementation for resizing
			Console.WriteLine($"Resizing image to {parameters.Parameters["size"]} pixels.");
		}
	}
}
