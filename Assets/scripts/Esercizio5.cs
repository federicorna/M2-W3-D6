using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;


public enum STATE
{
    IDLE,
    AGGROED,
    ATTACKING,
    DEFEATED
}

public class Esercizio5 : MonoBehaviour
{
    [SerializeField] private STATE state = STATE.IDLE;


    void Update()
    {
        STATE idle = STATE.IDLE;
        STATE aggroed = STATE.AGGROED;
        STATE attacking = STATE.ATTACKING;
        STATE deafited = STATE.DEFEATED;

        if (state == STATE.IDLE)
        {
            Debug.Log("Il nemico e' fermo");
        }
        else if (state == STATE.AGGROED)
        {
            Debug.Log("il nemico insegue il giocatore");
        }
        else if (state == STATE.ATTACKING)
        {
            Debug.Log("il nemico sta attaccando il giocatore");
        }
        else if (state == STATE.DEFEATED)
        {
            Debug.Log("il nemico e' sconfitto");
        }
    }
}
