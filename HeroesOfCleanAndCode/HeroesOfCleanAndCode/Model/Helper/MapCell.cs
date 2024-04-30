using HeroesOfCleanAndCode.Assets.Images;
using System.Windows.Controls;
using System.Windows.Media;

namespace HeroesOfCleanAndCode.Model.Helper
{
    public class MapCell
    {
        public Image terrainImage {  get; set; }
        public Image entityImage {  get; set; }
        public Brush entityColor { get; set; }
        public Image structureImage { get; set; }
        public Brush structureColor { get; set; }

        public MapCell()
        {
            terrainImage = new Image() { Source = Images.Empty };

            entityImage = new Image() { Source = Images.Empty };
            entityColor = Brushes.Gray;

            structureImage = new Image() { Source = Images.Empty };
            structureColor = Brushes.Gray;
        }

        public void ClearCell()
        {
            entityImage.Source = Images.Empty;
            entityColor = Brushes.Gray;

            structureImage.Source = Images.Empty;
            structureColor = Brushes.Gray;
        }
    }
}
