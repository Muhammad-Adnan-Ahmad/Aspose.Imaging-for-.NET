using System.IO;

using Aspose.Imaging;

namespace Aspose.Imaging.Examples.Files
{
    public class CreatingAnImageBySettingPath
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Creates an instance of BmpOptions and set its various properties
            Aspose.Imaging.ImageOptions.BmpOptions ImageOptions = new Aspose.Imaging.ImageOptions.BmpOptions();
            ImageOptions.BitsPerPixel = 24;


            //Define the source property for the instance of BmpOptions
            //Second boolean parameter determines if the file is temporal or not
            ImageOptions.Source = new Aspose.Imaging.Sources.FileCreateSource(dataDir + "output.bmp",false);


            //Creates an instance of Image and call Create method by passing the BmpOptions object
            using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Create(ImageOptions, 500, 500))
            {
                image.Save();
            }


        }
    }
}