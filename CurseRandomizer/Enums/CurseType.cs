﻿namespace CurseRandomizer;

public enum CurseType
{
    /// <summary>
    /// Let the player take 1 damage.
    /// </summary>
    Pain,

    /// <summary>
    /// Takes 50% of the players geo.
    /// </summary>
    Greed,

    /// <summary>
    /// Makes a charm useless.
    /// </summary>
    Normality,

    /// <summary>
    /// Remove a relic or charm notch.
    /// </summary>
    Lost,

    /// <summary>
    /// Removes a mask from the player.
    /// </summary>
    Emptiness,

    /// <summary>
    /// Teleports the player back to their bench. The other curses default to this if they cannot be executed.
    /// </summary>
    Disorientation,

    /// <summary>
    /// Reduces the nail damage by 1.
    /// </summary>
    Weakness,

    /// <summary>
    /// Spells costs 1 more soul.
    /// </summary>
    Stupidity,

    /// <summary>
    /// Hits grant 1 less soul.
    /// </summary>
    Thirst,

    /// <summary>
    /// A custom curse implemented by another mod.
    /// </summary>
    Custom
}
