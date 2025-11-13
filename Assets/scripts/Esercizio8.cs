using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DAMAGE_TYPE2
{
    SLASHING,
    PIERCING,
    BLUDGEONING,
    MAGICAL,
    FORCE
}
public class Esercizio8 : MonoBehaviour
{

    [SerializeField] private DAMAGE_TYPE2 attackType;
    [SerializeField] private DAMAGE_TYPE2 resistance;
    [SerializeField] private DAMAGE_TYPE2 weakness;
    [SerializeField] private int baseDamage = 10;

    void Start()
    {
        // minuto 42.50 lez pratica w4d2
    }

}
