using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerPrincipal : MonoBehaviour
{
    int contador;

    // Start is called before the first frame update
    void Start()
    {
        contador = 10;
        StopAllCoroutines();
        StartCoroutine("dutyCycle");
    }        

    IEnumerator dutyCycle() {
        while (true) {
            Debug.Log(contador.ToString());            
            if (--contador<0)
            {
                HandlerUI.CambiarEscena(2);
                break;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
