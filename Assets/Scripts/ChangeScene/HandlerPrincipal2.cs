using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerPrincipal2 : MonoBehaviour
{
    [SerializeField] int index_escena_destino;    
    [SerializeField] int contador;

    HandlerUI auxHandler; 

    // Start is called before the first frame update
    void Start()
    {
        auxHandler = new HandlerUI();

        //  contador = 10;
        StopAllCoroutines();
        StartCoroutine("dutyCycle");
    }        

    IEnumerator dutyCycle() {
        while (true) {
            Debug.Log(contador.ToString());            
            if (--contador<0)
            {
                auxHandler.CambiarEscena(index_escena_destino);
                break;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
