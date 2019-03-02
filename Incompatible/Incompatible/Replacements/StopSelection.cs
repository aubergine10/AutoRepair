﻿namespace Incompatible.Replacements
{
    public static class StopSelection
    {
        // recommend even if no broken mods? (must still have at least one deprecated mod subbed)
        static readonly bool always = false;

        // workshop id(s) of mod(s) to upgrade to
        static readonly ulong[] replacements = {
            1394468624 // Advanced Stop Selection by BloodyPenguin
        };

        // treat replacements as single combined item?
        static readonly bool combined = false;

        // why do the upgrade?
        static readonly string[] why = {
            "Replaces outdated 'multitrack station enabler' mods."
        };

        // workshop ids of mods deprecated by the upgrade
        static readonly ulong[] deprecates = {
            532863263, // * Multi-track Station Enabler
            442957897, // * Multi-track Station Enabler
        };
    }
}
