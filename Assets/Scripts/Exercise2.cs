using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    public string username= "admin";
    public string password= "abccba";
    
    
    private void Start()
    {
        Login(username,password);
    }
    
    
    
    bool Login(string user, string pass)
    {
        if (user == "admin" && pass == "abccba")

        {
            Debug.Log("You have successfully signed in.");

            return true;
        }
        else
        {
            Debug.Log("The user name or password provided is incorrect.");
            return false;
        }
    }
}
