using System;
using System.Collections.Generic;

namespace HeroesOfCleanAndCode.Model.Helper
{
    public class Direction
    {
        public readonly static Direction In = new Direction(0, 0);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Down = new Direction(1, 0);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction UpLeft = new Direction(-1, -1);
        public readonly static Direction UpRight = new Direction(-1, 1);
        public readonly static Direction DownLeft = new Direction(1, -1);
        public readonly static Direction DownRight = new Direction(1, 1);


        public int xOffset { get; }
        public int yOffset { get; }

        private Direction(int rowOffset, int colOffset)
        {
            xOffset = rowOffset;
            yOffset = colOffset;
        }

        public override bool Equals(object? obj)
        {
            return obj is Direction direction &&
                   xOffset == direction.xOffset &&
                   yOffset == direction.yOffset;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(xOffset, yOffset);
        }

        public static bool operator ==(Direction? x, Direction? y)
        {
            return EqualityComparer<Direction>.Default.Equals(x, y);
        }

        public static bool operator !=(Direction? x, Direction? y)
        {
            return !(x == y);
        }
    }
}
