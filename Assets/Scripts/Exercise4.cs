using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public int[] elements;

    private void Start()
    {
        Debug.Log($"First element={elements[0]}");
        Debug.Log($"Third element={elements[2]}");
        Debug.Log($"Fifth element={elements[4]}");
    }

}
