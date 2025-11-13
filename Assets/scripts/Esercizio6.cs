using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DAMAGE_TYPE
{
    SLASHING,
    PIERCING,
    BLUDGEONING,
    MAGICAL,
    FORCE
}

public class Esercizio6 : MonoBehaviour
{
    [SerializeField] private DAMAGE_TYPE attackType;
    [SerializeField] private DAMAGE_TYPE resistance;
    [SerializeField] private DAMAGE_TYPE weakness;
    [SerializeField] private int baseDamage = 10;


    // Start is called before the first frame update
    void Start()
    {
        if (attackType == resistance)
        {
            baseDamage /= 2;
            Debug.Log($"Il nemico e' resistente! danno {baseDamage}");
        }
        else if(attackType == weakness)
        {
            baseDamage *= 2;
            Debug.Log($"Il nemico e' debole! danno {baseDamage}");
        }
        Debug.Log(baseDamage);
    }

}
