using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HeroesOfCleanAndCode.Assets.Images
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

        public readonly static ImageSource Artillery = LoadImage("Artillery.png");
        public readonly static ImageSource Aviated = LoadImage("Aviated.png");
        public readonly static ImageSource Builder = LoadImage("Builder.png");
        public readonly static ImageSource Heavy = LoadImage("Heavy.png");
        public readonly static ImageSource Infantery = LoadImage("Infantery.png");
        public readonly static ImageSource Medic = LoadImage("Medic.png");

        public readonly static ImageSource City = LoadImage("City.png");

        //Add more images

        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/Images/{fileName}", UriKind.Relative));
        }
    }
}
