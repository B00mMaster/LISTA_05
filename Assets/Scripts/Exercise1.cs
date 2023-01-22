using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public float one;

    public float two;

    public float three;

     float result;


    private void Start()
    {
        Arithmetic(one, two, three, result);
    }

    void Arithmetic(float x, float y, float z, float result)
    {
        result = (x + y + z) / 3;

        Debug.Log($"The arithmetic mean of {x}, {y} and {z} is {result}");

        
        
    }
}
