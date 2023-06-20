﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballPredictionBlazor.Shared
{
    public static class MLModelPredictionType
    {
        /// <summary>
        /// Predict the probability of the baseball player being on the BALLOT of the Hall of Fame.
        /// </summary>
        public const string OnHallOfFameBallot = "OnHallOfFameBallot";

        /// <summary>
        /// Predict the probability of the baseball player being INDUCTED to the Hall of Fame.
        /// </summary>
        public const string InductedToHallOfFame = "InductedToHallOfFame";

        public static string GetPredictionLabel(string mlModelPredictionType, bool isProbability)
        {
            var predictionLabel = string.Empty;
            var predictionLabelSuffix = "Probability";

            if (mlModelPredictionType == OnHallOfFameBallot)
            {
                predictionLabel = "Ballot";
            }
            else
            {
                predictionLabel = "Induction";
            }

            if (!isProbability)
            {
                predictionLabelSuffix = "Category";
            }

            return string.Format("{0} {1}", predictionLabel, predictionLabelSuffix);
        }
    }
}
