using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public class TriggerZone : MonoBehaviour
    {
       // public delegate void TriggerAction();
        //public static event TriggerAction OnTrigger;


        public void OnTriggerEnter(Collider other)
        {

        Destroy(other.gameObject);
        
        }
    }
}
