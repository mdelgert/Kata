/*
File: Dice.cs
Author: Matthew David Elgert
Created: 3/15/2017
Modified: 3/15/2017
Notes: Stores dice model data
*/

using System;

namespace KataYahtzee.Model
{
    public class DiceModel
    {
        private int diceId;
        private Boolean isPair;
        private int diceValue;

        /// <summary>
        /// Gets or sets dice ID
        /// </summary>
        public int DiceId
        {
            get { return diceId; }
            set { diceId = value; }
        }

        /// <summary>
        /// Gets or sets has pair
        /// </summary>
        public Boolean IsPair
        {
            get { return isPair; }
            set { isPair = value; }
        }

        /// <summary>
        /// Gets or sets dice value
        /// </summary>
        public int DiceValue
        {
            get { return diceValue; }
            set { diceValue = value; }
        }


    }


}

