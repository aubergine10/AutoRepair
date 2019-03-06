﻿using System.Collections.Generic;

namespace Incompatible.Replacements.Scripts
{
    class PrecisionEngineering : ReplacementBase, IReplacement
    {
        protected new readonly Dictionary<ulong, byte> replacements = new Dictionary<ulong, byte>()
        {
            { 1548831935, 1 } // Precision Engineering by Simie
        };

        protected new readonly Dictionary<byte, string> notes = new Dictionary<byte, string>()
        {
            { 1, "Precision Engineering replaces the obsolete Road Protactor mod." }
        };

        protected new readonly Dictionary<ulong, byte> deprecates = new Dictionary<ulong, byte>()
        {
            { 436253779, 1 } // * Road protractor
        };
    }
}