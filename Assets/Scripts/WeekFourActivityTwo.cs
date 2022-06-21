using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekFourActivityTwo : MonoBehaviour
{
    private float DegreesFa = 0;

    // Start is called before the first frame update
    void Start()
    {

        TempConvert();
    }

    // Update is called once per frame
    void TempConvert()
    {
        float DegreesFa = Random.Range(0, 300);

        float DegreesCelsius = (DegreesFa - 32) * 5 / 9;

        Debug.Log("Temperature is " + DegreesCelsius + "Celsius");

    }
}
