using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;


public enum STATE2
{
    IDLE,
    AGGROED,
    ATTACKING,
    DEFEATED
}

public class Esercizio7 : MonoBehaviour
{
    [SerializeField] private STATE2 state2 = STATE2.IDLE;

    void Update()
    {
        STATE2 idle = STATE2.IDLE;
        STATE2 aggroed = STATE2.AGGROED;
        STATE2 attacking = STATE2.ATTACKING;
        STATE2 deafited = STATE2.DEFEATED;

        switch (state2)
        {
            case STATE2.IDLE:
                Debug.Log("il nemico e' fermo");
                break;
            case STATE2.AGGROED :
                Debug.Log("il nemico insegue il giocatore");
                break;
            case STATE2.ATTACKING:
                Debug.Log("il nemico attacca il giocatore");
                break;
            case STATE2.DEFEATED:
                Debug.Log("il nemico e' sconfitto");
                break;

        }
    }
}
