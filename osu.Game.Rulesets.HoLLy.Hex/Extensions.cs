﻿using System;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.HoLLy.Hex.Beatmaps;
using OpenTK;

namespace osu.Game.Rulesets.HoLLy.Hex
{
    internal static class Extensions
    {
        public static int GetLaneCount(this IBeatmap b) => b is HexBeatmap hb && hb.LaneCount.HasValue ? hb.LaneCount.Value : Utils.GetLaneCount(b.BeatmapInfo.BaseDifficulty.OverallDifficulty);

        public static double AngleRadians(this Vector2 v) => Math.Atan2(v.X, v.Y);
        public static double AngleAngles(this Vector2 v) => v.AngleRadians() / Math.PI * 360d;
    }
}
