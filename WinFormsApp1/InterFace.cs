using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{ 
    internal class InterFace
    { 

        public static string inputPath = Application.StartupPath;
        public static string outputPath = Application.StartupPath;
        public static int scale =4;
        public static string modelName = "realesrgan-x4plus";
        public static string format = "png";

        public static bool folderBasedProccessing = true;

    }
}
