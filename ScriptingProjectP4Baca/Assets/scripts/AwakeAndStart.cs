using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake called.");
    }

    // Update is called once per frame
    void Start()
    {
        Debug.Log("Start called.");
    }
}