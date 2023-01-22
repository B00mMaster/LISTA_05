using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{

    public int counter;
   
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
             Calculator(counter);
             counter++; 
        }
            
    }

    void Calculator(int one)
    {
        

        if (one>=9)
        {
            Debug.Log("GAME OVER");

        }
    }







}




