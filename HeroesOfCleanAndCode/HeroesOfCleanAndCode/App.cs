using HeroesOfCleanAndCode.Model.Core;
using HeroesOfCleanAndCode.Model.Enums;
using System;
using System.Windows;

namespace HeroesOfCleanAndCode
{
    public partial class App : Application
    {

        [STAThread]
        public static void Main(string[] args)
        {
            Application app = new Application();

            app.Run(new MainWindow());
        }
    }
}
