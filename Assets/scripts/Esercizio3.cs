using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    [SerializeField] private int dividendo = 0;
    [SerializeField] private int divisore = 0;

    bool SafeDivide(int dividendo, int divisore, out int risultato)
    {

        if (divisore == 0)
        {
            risultato = 0;
            return false;
        }
        else
        {
            risultato = dividendo / divisore;

        }
        return true;
    }
    // Start is called before the first frame update 
    void Start()
    {
        int risultato = 0;
        SafeDivide(dividendo, divisore, out risultato);

        if (dividendo != 0)
        {
            Debug.Log($"{dividendo} / {divisore} = {risultato}");
        }
        else
        {
            Debug.LogWarning("Il divisore non può essere zero");
        }
    }

}