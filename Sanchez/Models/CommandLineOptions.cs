﻿using CommandLine;
using JetBrains.Annotations;

namespace Sanchez.Models
{
    /// <summary>
    ///     All command-line options supported by Sanchez.
    /// </summary>
    [UsedImplicitly]
    public class CommandLineOptions
    {
        [Option('u', "underlay", HelpText = "Path to full-colour underlay image", Required = true)]
        public string? UnderlayPath { get; [UsedImplicitly] set; }

        [Option('s', "source", HelpText = "Path to IR satellite image", Required = true)]
        public string? SourceImagePath { get; [UsedImplicitly] set; }

        [Option('m', "mask", HelpText = "Optional path to mask image", Required = false)]
        public string? MaskPath { get; [UsedImplicitly] set; }

        [Option('O', "overlay", HelpText = "Optional path to overlay image", Required = false)]
        public string? OverlayPath { get; [UsedImplicitly] set; }

        [Option('o', "output", HelpText = "Path to output file", Required = true)]
        public string? OutputFile { get; [UsedImplicitly] set; }

        [Option('t', "tint", HelpText = "Tint to apply to satellite image", Required = false, Default = "5ebfff")]
        public string Tint { get; [UsedImplicitly] set; } = null!;

        [Option('b', "brightness", HelpText = "Brightness adjustment", Required = false, Default = 1.2f)]
        public float Brightness { get; [UsedImplicitly] set; }

        [Option('S', "saturation", HelpText = "Saturation adjustment", Required = false, Default = 0.7f)]
        public float Saturation { get; [UsedImplicitly] set; }
    }
}