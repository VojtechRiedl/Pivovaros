using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Pivo
    {
        public static int rychlostVyroby {  get; protected set; } = 1;
        public static float chmel { get; protected set; } = 230f;
        public static float voda { get; protected set; } = 180f;
        public static float slad { get; protected set; } = 500f;
        public static float kvasinky { get; protected set; } = 350f;

    }
}
