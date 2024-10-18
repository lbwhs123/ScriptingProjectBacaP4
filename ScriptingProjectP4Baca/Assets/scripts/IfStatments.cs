using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatments : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();


        coffeeTemperature -= Time.deltaTime * 5f;
    }



    void TemperatureTest()
    {
        // If the coffee's temperatureis greater than the hottest drinking temperature ...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // if this isn't, but the coffee temperature is less than the coldest drinking temperature ...
        else if (coffeeTemperature > coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // if it is nethier of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}
            
