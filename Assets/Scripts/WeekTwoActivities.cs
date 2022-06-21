using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RachelleBray
{
    public class WeekTwoActivities : MonoBehaviour
    {
        //Info about my favourite game (name, hours played, cost)
        private string favouriteGame = "Animal Crossing";
        private float hoursPlayed = 1000;
        private float cost = 69;

        // Start is called before the first frame update
        void Start()
        {
            float dollarsPerHour;
            dollarsPerHour = cost / hoursPlayed;

            Debug.Log("My favourite game is " + favouriteGame + ", I have played it for " + hoursPlayed + " hours and it cost me $" + cost + ". Therefore, my value of dollars per hour is: $" + dollarsPerHour.ToString("0.00") + ".");
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }

}
