using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    void Swap(int a, int b)
    {
        int varSwap = 0;
        varSwap = a;
        a = b;
        b = varSwap;
        //Debug.Log("valore a " + a + "valore b " + b); 
    }

    void SwapRef(ref int a, ref int b)
    {
        int varSwap = 0;
        varSwap = a;
        a = b;
        b = varSwap;
        //Debug.Log("valore a " + a + "valore b " + b); 
    }


    void Start()
    {
        int a = 3, b = 6;

        Swap(a, b);

        Debug.Log("valori con Swap: " + a + " e " + b);

        SwapRef(ref a, ref b);

        Debug.Log("valori con SwapRef: " + a + " e " + b);
    }
}