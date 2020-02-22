using System;
using System.Collections;
using System.Collections.Generic;

namespace Benediction.Board
{
    public sealed class StateEnumerator : IEnumerator<KeyValuePair<Location, Cell>>
    {
        public StateEnumerator(Board.State state)
        {
            _state = state;
        }

        private readonly Location[] indices = new[]
        {
            Location.A1, Location.A2, Location.A3, Location.A4, Location.A5, Location.B1, Location.B2, Location.B3,
            Location.B4, Location.B5, Location.B6, Location.C1, Location.C2, Location.C3, Location.C4, Location.C5,
            Location.C6, Location.C7, Location.D1, Location.D2, Location.D3, Location.D4, Location.D5, Location.D6,
            Location.D7, Location.D8, Location.E1, Location.E2, Location.E3, Location.E4, Location.E5, Location.E6,
            Location.E7, Location.E8, Location.E9, Location.F1, Location.F2, Location.F3, Location.F4, Location.F5,
            Location.F6, Location.F7, Location.F8, Location.G1, Location.G2, Location.G3, Location.G4, Location.G5,
            Location.G6, Location.G7, Location.H1, Location.H2, Location.H3, Location.H4, Location.H5, Location.H6,
            Location.I1, Location.I2, Location.I3, Location.I4, Location.I5,
        };

        private Board.State _state;
        private int _idx = -1;

        public KeyValuePair<Location, Cell> Current
        {
            get
            {
                if (_idx < 0 || _idx >= indices.Length) throw new InvalidOperationException();
                return new KeyValuePair<Location, Cell>(indices[_idx], _state[indices[_idx]]);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                if (_idx < 0 || _idx >= indices.Length) throw new InvalidOperationException();
                return new KeyValuePair<Location, Cell>(indices[_idx], _state[indices[_idx]]);
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return ++_idx < indices.Length;
        }

        public void Reset()
        {
            _idx = -1;
        }
    }
}
