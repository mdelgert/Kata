/*
File: GameLogic.cs
Author: Matthew David Elgert
Created: 3/15/2017
Modified: 3/15/2017
Notes: Stores buisness logic of game
*/

using System;
using KataYahtzee.Model;

namespace KataYahtzee.BLL
{

    public class GameLogic
    {

       
        public static void PrintDiceValues()
        {

            //1. Role dice logic

            var diceSet = new GameLogic().GetDiceSet();

            //2. Score logic

            foreach (DiceModel dice in diceSet)
            {
                CheckMatchId(dice, diceSet); //This logic checks for matches
            }

            //3. Print results 


            foreach (DiceModel dice in diceSet)
            {
                //Console.WriteLine(dice.DiceId.ToString());
                Console.WriteLine(dice.DiceValue.ToString());
                Console.WriteLine(dice.IsPair.ToString());
            }


            //todo finish adding other logic this format will allow for dynamic changes easily!


        }


        public static void CheckMatchId (DiceModel diceModel, object[] diceSet)
        {
            foreach (DiceModel dice in diceSet)
            {
                if (dice.DiceId != diceModel.DiceId) //skip checking with with own dice id
                {

                    if (dice.DiceValue == diceModel.DiceValue)
                    {
                        dice.IsPair = true;
                    }

                }

            }

        }

        public object[] GetDiceSet()
        {

            int diceCount = 6;

            // Create the array to store dice set of data 

            DiceModel[] diceSet = new DiceModel[diceCount];

            for (int i = 0; i < diceCount; i++)
            {

                diceSet[i] = new DiceModel();
                diceSet[i].DiceId = i;
                diceSet[i].DiceValue = ReturnRollValue();
                diceSet[i].IsPair = false;
            }

            return diceSet;

        }


        public static int ReturnRollValue()
        {
            //.net random gives many duplicates, I've added a little logic to help simulate how dice typically roll in real life.
             
            int r = 7;
            Random rS = new Random(System.DateTime.Now.Millisecond);
            do
            {
               r = rS.Next(1, 9999999);
            } while (r >= 6); //keep looping until dice value is below 6

            return r; 
        }


    }

}



