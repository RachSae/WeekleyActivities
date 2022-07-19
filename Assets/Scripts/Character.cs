using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RachelleBray
{


    public class Character : MonoBehaviour
    {
        public int health = 100;
        public int morale = 100;

        private void Update()
        {
            if (morale <= 50)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }


        }

    }
}
