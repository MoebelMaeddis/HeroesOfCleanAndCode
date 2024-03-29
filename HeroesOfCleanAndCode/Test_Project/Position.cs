using System;
using System.Collections.Generic;

namespace HeroesOfCleanAndCode
{
    public class Position
    {
        public int x { get; }
        public int y { get; }
        public enum MapSize
        {
            Tiny = 20,
            Small = 30,
            Medium = 50,
            Large = 75,
            Huge = 100,
        }

        public Position(MapSize mapSize)
        {
            Random random = new Random();

            x = random.Next();
            y = random.Next();
        }
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Position Translate(Direction dir)
        {
            return new Position(x + dir.xOffset, y + dir.yOffset);
        }

        public override bool Equals(object? obj)
        {
            return obj is Position pos &&
                   x == pos.x &&
                   y == pos.y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }

        public static bool operator ==(Position? left, Position? right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position? left, Position? right)
        {
            return !(left == right);
        }
    }
}
