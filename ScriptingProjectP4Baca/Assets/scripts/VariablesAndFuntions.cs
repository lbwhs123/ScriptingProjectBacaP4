using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VariablesAndFuntions : MonoBehaviour
{
    //Create a variable of type int
    int myInt = 12;

    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }


    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}