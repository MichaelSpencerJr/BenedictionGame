using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Benediction.Board;

namespace Benediction.Heuristic
{
    /// <summary>
    /// Heuristic classifier
    /// </summary>
    public abstract class ClassifierBase
    {
        /// <summary>
        /// Name of this classifier
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Classifies the provided board state.
        /// </summary>
        /// <param name="state">Board state to classify</param>
        /// <returns>Board classification</returns>
        public abstract double Score(State state);
    }
}
