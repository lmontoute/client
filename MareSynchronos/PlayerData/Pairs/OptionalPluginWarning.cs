﻿namespace MareSynchronos.PlayerData.Pairs;

public record OptionalPluginWarning
{
    public bool ShownHeelsWarning { get; set; } = false;
    public bool ShownCustomizePlusWarning { get; set; } = false;
    public bool ShownPalettePlusWarning { get; set; } = false;
}