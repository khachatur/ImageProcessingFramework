namespace ImageProcessingFramework.Models
{
	public class ImageData
	{
		public string Name { get; set; }
		public byte[] Data { get; set; }

		public ImageData()
		{
			Name = "DummyImage";
			Data = new byte[0];
		}
	}
}
