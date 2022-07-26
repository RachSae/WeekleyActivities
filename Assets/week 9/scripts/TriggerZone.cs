using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RachelleBray
{ 

    public class TriggerZone : MonoBehaviour
    {
        public delegate void TriggerAction();
           public static event TriggerAction OnTrigger;

        //Detect when the sphere hits the trigger
        //Debug.log something
        //telepor the sphere away

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Ouch! "+other.name+ " hit me!");

            //other.transform.position = new Vector3(0, 2, 0);
          if(OnTrigger != null)
            {
                OnTrigger();
            }
        }




    }
}