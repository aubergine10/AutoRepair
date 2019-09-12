﻿namespace AutoRepair.Replacements.Scripts
{
    /*
    * Why recommend upgrading 'More Beautification' to 'Find It'?
    * 
    * 1. More Beautification mod causes severe lag (especially on potato computers) when
    *    opening the build menu.
    * 
    * 2. Find It provides access to far more assets, has additional filters and a search tool.
    * 
    * 3. Find It is a prerequisite for some popular mods, such as Plop the Growables
    * 
    * For these reasons, 'Find It' is considered more suitable for end-users.
   */

    class FindIt : ReplacementBase
    {
        public FindIt()
        {
            mandatory = true;

            option.Add(837734529u, 1); // Find It! by SamSamTS

            note.Add(1, "'Find It!' adds a searchable and filterable build menu providing access to all assets including props.");

            deprecated.Add(505480567, 1); // More beautification (causes lag)

            obsolete.Add(540758804, 1); // * Search Box Mod
        }
    }
}
