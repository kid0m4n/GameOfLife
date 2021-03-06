﻿namespace GameOfLife {
    using System;

    public struct Coordinate : IEquatable<Coordinate>, IComparable<Coordinate> {
        private readonly int _x, _y;

        public int X { get { return _x; } }
        public int Y { get { return _y; } }

        public Coordinate(int x, int y) {
            _x = x;
            _y = y;
        }

        public override bool Equals(object obj) {
            if (obj == null)
                return base.Equals(obj);

            if (obj is Coordinate)
                return Equals((Coordinate)obj);

            return false;
        }

        public override int GetHashCode() {
            return (_x * 0x1f1f1f1f) ^ _y;
        }

        public override string ToString() {
            return string.Format("[{0},{1}]", _x, _y);
        }

        public bool Equals(Coordinate other) {
            return _x == other._x && _y == other._y;
        }

        public int CompareTo(Coordinate other) {
            return (_x < other._x) ? -1 : ((_x > other._x) ? 1 : ((_y < other._y) ? -1 : ((_y > other._y) ? 1 : 0)));
        }
    }
}
