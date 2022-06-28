using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RachelleBray
{
    public class CheatSheet : MonoBehaviour
    {
        // TODO: Set up templates for class/variable/function/if-else/for loop

        //to declare a variable
        // we need a variable to declare eg. high score lowerCamelCase
        // accessModifier Type nameOfVariable
        public int score;
        public int highScore;
    }

    //To declare a class, we need:
    // [accessModifier] [the word "class" [ClassName]

    public class ExampleClass : MonoBehaviour
    {
        //MonoBehaviour if attached to game object
        //This class can be accessed from other classes because it is public
        // You can not make a private class (in general)

        void Start()
        {
            sheet.score = 10;
        }

        //To declare a method
        // accessModifier ReturnType nameYouGiveMethod Name requires PascalCase not camelCase
        // You can include parameters as in second examp[le below
        // eg. a method that resets the high score
        public void ScoreReset()
        {
            //this is the template
            score = 0;

           
        }

        public void AddScore(int amount)
        {
            score = score + amount;

            //to declare an "if statement" we use this syntax:
            // note: it needs to be inside a method
            // if ([condition] [operator] [condition]) {}
            //for example to check if our score is higher thasn the new high score
            score = 10;
            highScore = 5;

            if(score > highScore)
            {
                highScore = score
            }

            public void ResetGame()
            {   for (int i = 0; i < 5; i++)
            

            }
        }


    }
}
