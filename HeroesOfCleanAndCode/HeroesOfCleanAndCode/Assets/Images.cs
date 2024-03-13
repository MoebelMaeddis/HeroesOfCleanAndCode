using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HeroesOfCleanAndCode
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource Forest = LoadImage("Forest.png");
        public readonly static ImageSource Grass = LoadImage("Grass.png");
        public readonly static ImageSource Mountain = LoadImage("Mountain.png");
        public readonly static ImageSource Ore = LoadImage("Ore.png");
        public readonly static ImageSource River = LoadImage("River.png");
        public readonly static ImageSource Water = LoadImage("Water.png");
        //Add more images

        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/Images/{fileName}", UriKind.Relative));
        }
    }
}
