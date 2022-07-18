using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RachelleBray
{ 

public class CharacterColourChanger : MonoBehaviour
    {
        // we need a reference to the character we will change the colour of
        [SerializeField] private MeshRenderer simpleCharacterRenderer;

   
    // Update is called once per frame
     void Update()
        {
            //We need to change the characters colour if it has an X position < or > 0
            if (simpleCharacterRenderer.gameObject.transform.position.x > 0)
            {
                simpleCharacterRenderer.material.color = Color.green;
            }
            else
            {
                simpleCharacterRenderer.material.color = Color.red;
            }
            
        }
    }
}