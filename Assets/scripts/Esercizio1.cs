using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    void Start()
    {
        int a = 5;
        int b = 6;
        int varSwap = 0;

        Debug.Log("valori precedenti: " + a + " e " + b);

        varSwap = a;
        a = b;
        b = varSwap;

        Debug.Log("valori attuali: " + a + " e " + b);
    }
}