using System;
using ImageProcessingFramework.Interfaces;
using ImageProcessingFramework.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ImageProcessingFramework.Plugins
{
	public class GrayscaleEffect : IPlugin
	{
		public void ApplyEffect(ImageData image, EffectParameters parameters)
		{
			// Dummy implementation for converting to grayscale
			Console.WriteLine("Converting image to grayscale.");
		}
	}
}
