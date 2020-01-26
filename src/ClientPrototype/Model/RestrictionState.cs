using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benediction.Model
{
    [Flags]
    public enum RestrictionState
    {
        None,
        EditorLocked,
        RewindLocked
    }
}
