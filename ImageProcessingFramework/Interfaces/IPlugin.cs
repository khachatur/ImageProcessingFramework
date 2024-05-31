using ImageProcessingFramework.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ImageProcessingFramework.Interfaces
{
	public interface IPlugin
	{
		void ApplyEffect(Models.ImageData image, EffectParameters parameters);
	}
}
