using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RachelleBray
{
    public class WeekThreeActivities : MonoBehaviour
    { 

      
    
        // Start is called before the first frame update
        void Start()
        {

            int playerOneStrength = Random.Range(1, 11);
            int playerOneAgility = Random.Range(1, 6);
            int playerOneIntel = Random.Range(1, 11);
            int playerTwoStrength = Random.Range(1, 11);
            int playerTwoAgility = Random.Range(1, 6);
            int playerTwoIntel = Random.Range(1, 11);

           
            int playerOnePowerLevel = (int)((playerOneStrength * 2) + (playerOneAgility * 1.5f) + playerOneIntel);
            int playerTwoPowerLevel = (int)((playerTwoStrength * 2) + (playerTwoAgility * 1.5f) + playerTwoIntel);

            if (playerOnePowerLevel > playerTwoPowerLevel)
            {
                Debug.Log("The Winner is Player One!");
            }
            else if (playerTwoPowerLevel > playerOnePowerLevel) Debug.Log("The Winner is Player Two!");
            
            else
            {
                Debug.Log("It's a draw!");
            }

            Debug.Log("Player one has power level " +playerOnePowerLevel+ ".");
            Debug.Log("Player Two has power level " +playerTwoPowerLevel+ ".");

            float totalPower = playerOnePowerLevel + playerTwoPowerLevel;
            float playerOneChanceToWin = playerOnePowerLevel / totalPower * 100;
            float playerTwoChanceToWin = playerTwoPowerLevel / totalPower * 100;
            float playOneWinsBy = playerOneChanceToWin - playerTwoChanceToWin;
            float playTwoWinsBy = playerTwoChanceToWin - playerOneChanceToWin;

            if (playerOnePowerLevel > playerTwoPowerLevel) Debug.Log("Player One wins by " + playOneWinsBy.ToString("0") + "%");
            else Debug.Log("Player Two wins by " +playTwoWinsBy.ToString("0")+ "%");


        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}