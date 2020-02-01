using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benediction.Actions;
using Benediction.Board;
using Benediction.View;
using Testing.Specflow.Properties;

namespace Testing.Specflow.Common
{
    public static class BoardPrinter
    {
        public static string ImageMarkdown(this State state, Location select1 = Location.Undefined, Location select2 = Location.Undefined)
        {
            var filename = state.BoardFilename(select1, select2);

#pragma warning disable SecurityIntelliSenseCS 
            // Filename comes from two constrained inputs, a GUID and a Location 
            // struct, neither of which can change the structure of the path.
            var target = Path.Combine(Resources.ImagePath, filename);
#pragma warning restore SecurityIntelliSenseCS // MS Security rules violation

            state.WriteBoardImage(target, select1, select2);
            return $"![Board Snapshot](https://raw.githubusercontent.com/MichaelSpencerJr/BenedictionGame/master/testruns/images/{filename}?raw=true)";
        }

        public static void WriteBoardImage(this State state, string pathname, Location select1, Location select2)
        {
            if (File.Exists(pathname)) return;

            var boardImage =
                BoardPainter.DrawBoard(state, select1, select2, null, false, Point.Empty);
            boardImage.Save(pathname, ImageFormat.Png);
        }

        private static string BoardFilename(this State state, Location select1, Location select2)
        {
            var s1Part = select1 == Location.Undefined ? string.Empty : $"-{select1}";
            var s2Part = select2 == Location.Undefined ? string.Empty : $"-{select2}";
            var compare = string.Compare(s1Part, s2Part, StringComparison.InvariantCultureIgnoreCase);
            var selectPart = compare == 0 ? s1Part :
                compare < 0 ? string.Concat(s1Part, s2Part) : string.Concat(s2Part, s2Part);
            return $"{state.BoardId}{selectPart}.png";
        }
    }
}
