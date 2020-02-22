using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using State = Benediction.Board.State;


namespace Benediction.Board
{
    public static class StateManager
    {
        public static State Create()
        {
            return new State();
        }

        public static State Create(Location redHome, Location blueHome)
        {
            return new State {RedHome = redHome, BlueHome = blueHome};
        }

        public static byte[] GetBytes(State state)
        {
            var size = Marshal.SizeOf(state);
            var bytes = new byte[size];
            var ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(state, ptr, true);
            Marshal.Copy(ptr, bytes, 0, size);
            Marshal.FreeHGlobal(ptr);
            return bytes;
        }

        public static State FromBytes(byte[] bytes)
        {
            var state = new State();
            var size = Marshal.SizeOf(state);
            var ptr = Marshal.AllocHGlobal(size);
            Marshal.Copy(bytes, 0, ptr, size);
            state = (State) Marshal.PtrToStructure(ptr, typeof(State));
            Marshal.FreeHGlobal(ptr);
            return state;
        }
    }
}
