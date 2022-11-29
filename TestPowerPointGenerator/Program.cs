using System;
using System.IO;
using System.Linq;
using PowerPointGenerator;

namespace TestPowerPointGenerator
{
    static class Program
    {
        static void Main()
        {
            var powerPointGenerator = new PowerPointFactory(Path.Combine(@"c:\a\ppt.pptx"));
            var imageFilePaths = Directory.GetFiles(@"..\..\..\Alba", "*.jpg").ToList();
             powerPointGenerator.CreateTitleAndImageSlides(imageFilePaths);
            // powerPointGenerator.CreateTitleAndImageSlides
           
        }
    }
}
