using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    [SerializeField] private int value;
    [SerializeField] private int dex;
    [SerializeField] private int time;


    int Find(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                Debug.Log($"l'indice di value è {i}");
            }
        }
        return 10000000;
    }

    void PutToTheBack(int[] array, int index)
    {
        int ultimoIndice = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == index)
            {
                int daSpos = array[i];
                for (int j = index + 1; j < array.Length; j++)
                {

                }

            }
        }
    }

    void ShiftOnce(int[] array)
    {

    }

    void Shift(int[] array, int times)
    {

    }

    void Start()
    {
        int dim = 10;
        int[] array = new int[dim];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(0, 11);
            Debug.Log(array[i]);
        }

        Find(array, value);
        //PutToTheBack() 



    }
}