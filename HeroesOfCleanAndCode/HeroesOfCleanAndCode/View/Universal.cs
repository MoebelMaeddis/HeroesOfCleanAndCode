using System;
using System.Windows;
using System.Windows.Controls;

namespace HeroesOfCleanAndCode.View
{
    public class Universal
    {
        public static void GridDefinitions(Grid grid, Tuple<int,int> sizeXY)
        {
            int x = sizeXY.Item1; //Columns
            int y = sizeXY.Item2; //Rows

            for (int i = 0; i < x; i++)
                grid.ColumnDefinitions.Add(new ColumnDefinition() { });

            for (int i = 0; i < y; i++)
                grid.RowDefinitions.Add(new RowDefinition() { });
        }
    }
}
