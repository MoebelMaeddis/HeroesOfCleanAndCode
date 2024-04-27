using System.Windows.Controls;

namespace HeroesOfCleanAndCode.View
{
    public static class Styles
    {
        private static int DefaultFontSize = 12;
        private static int DefaultMargin = 2;
        private static int DefaultThickness = 1;
        private static System.Windows.Media.Brush DefaultBackground = System.Windows.Media.Brushes.LightGray;
        private static System.Windows.Media.Brush DefaultBorderBrush = System.Windows.Media.Brushes.Black;


        public static void SetInfoButtonStyle(Button button)
        {
            DefaultButtonStyle(button);

            // Custom button style
        }

        public static void SetInfoLabelStyle(Label label)
        {
            DefaultLabelStyle(label);

            // Custom label style
        }

        public static void DefaultButtonStyle(Button button)
        {
            button.Margin = new System.Windows.Thickness(DefaultMargin);
            button.Background = DefaultBackground;
            button.BorderThickness = new System.Windows.Thickness(DefaultThickness);
            button.BorderBrush = DefaultBorderBrush;
        }

        public static void DefaultLabelStyle(Label label)
        {
            label.Margin = new System.Windows.Thickness(DefaultMargin);
            label.Background = DefaultBackground;
            label.BorderThickness = new System.Windows.Thickness(DefaultThickness);
            label.BorderBrush = DefaultBorderBrush;
        }

    }
}
