using System;
using System.Collections.Generic;
using ImageProcessingFramework.Models;
using ImageProcessingFramework.Interfaces;

namespace ImageProcessingFramework.Services
{
	public class ImageProcessor
	{
		private List<ImageTask> _imageTasks;

		public ImageProcessor()
		{
			_imageTasks = new List<ImageTask>();
		}

		public void AddImageTask(ImageTask task)
		{
			_imageTasks.Add(task);
		}

		public void ProcessImages()
		{
			foreach (var task in _imageTasks)
			{
				task.ApplyEffects();
			}
		}

		// Public method to access _imageTasks for testing
		public List<ImageTask> GetImageTasks()
		{
			return _imageTasks;
		}
	}

	public class ImageTask
	{
		public ImageData Image { get; set; }
		public List<IPlugin> Plugins { get; set; }
		public List<EffectParameters> EffectParameters { get; set; }

		public ImageTask()
		{
			Plugins = new List<IPlugin>();
			EffectParameters = new List<EffectParameters>();
		}

		public void ApplyEffects()
		{
			for (int i = 0; i < Plugins.Count; i++)
			{
				Plugins[i].ApplyEffect(Image, EffectParameters[i]);
			}
		}
	}
}
