using System.Windows.Controls.Primitives;
using HeroesOfCleanAndCode.Interfaces;
using HeroesOfCleanAndCode.Controller.Map;

namespace HeroesOfCleanAndCode.View.Map
{
    public class MapView : UniformGrid, IView
    {
        public MapView()
        {
            Controller = new MapController(this);

            InitLayout();
        }

        public void InitLayout()
        {
            Columns = 10;
            Rows = 10;
            HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            VerticalAlignment = System.Windows.VerticalAlignment.Center;

            for (int i = 0; i < 100; i++)
            {
                Children.Add(new ToggleButton());
            }
        }
    }
}
