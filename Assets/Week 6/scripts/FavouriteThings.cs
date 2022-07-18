using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FavouriteThings : MonoBehaviour
{
    string[] favouriteColours = { "pink", "purple", "blue" };
    List<string> favouriteAnimals = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        favouriteAnimals.Add("Lions");
        favouriteAnimals.Add("Cats");


        //array "Length" list "Count"
        for (int i = 0; i < favouriteColours.Length; i++)
        {
            Debug.Log(favouriteColours[i]);
        }

        for (int i = 0; i < favouriteAnimals.Count; i++)
        {
            Debug.Log(favouriteAnimals[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
