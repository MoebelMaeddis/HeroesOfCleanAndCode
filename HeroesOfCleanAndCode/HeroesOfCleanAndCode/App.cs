using System;
using System.Windows;

namespace HeroesOfCleanAndCode
{
    public class App
    {

        [STAThread]
        public static void Main(string[] args)
        {
            Application app = new Application();

            app.Run(new MainWindow());
        }
    }
}
