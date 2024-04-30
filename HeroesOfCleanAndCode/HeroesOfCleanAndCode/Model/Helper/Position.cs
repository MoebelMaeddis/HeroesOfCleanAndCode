using System;
using System.Collections.Generic;
using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode.Model.Helper
{
    public class Position
    {
        public int x { get; }
        public int y { get; }

        public Position(MapSize mapSize, MapRelation mapRelation)
        {
            Random random = new Random();

            x = random.Next((int)mapSize * (int)mapRelation);
            y = random.Next((int)mapSize);
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
