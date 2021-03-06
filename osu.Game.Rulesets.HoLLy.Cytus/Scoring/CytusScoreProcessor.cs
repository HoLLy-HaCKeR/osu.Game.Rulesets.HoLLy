﻿using osu.Game.Rulesets.HoLLy.Cytus.Objects;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.HoLLy.Cytus.Scoring
{
    internal class CytusScoreProcessor : ScoreProcessor<CytusHitObject>
    {
        protected CytusScoreProcessor() { }
        public CytusScoreProcessor(RulesetContainer<CytusHitObject> rulesetContainer) : base(rulesetContainer) { }
    }
}
