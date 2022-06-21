using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekFourActivities : MonoBehaviour
{
    private int Year = 0;

    // Start is called before the first frame update

    void Start()
    {

        Year = Random.Range(0, 2050);

        LeapYear();
    }

    // Update is called once per frame
    public void LeapYear()
    {
        if (Year % 4 == 0)
        {
            Debug.Log(+Year+ " Sure");
        }
        else Debug.Log(+Year+ " Nope");
    }
}
