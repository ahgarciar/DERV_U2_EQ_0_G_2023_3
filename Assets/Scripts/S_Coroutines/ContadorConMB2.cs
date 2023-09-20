using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorConMB2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt_contador;
    int contador = 0;

    float tiempoIntervalo = 1;
    float tiempoActual;

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempoActual += Time.deltaTime;
        Debug.Log("Tiempo Actual: " + tiempoActual.ToString());

        if (tiempoActual >= tiempoIntervalo)
        {            
            txt_contador.text = contador++.ToString();            
            tiempoActual = 0; //reinicia el contador
        }
        
    }
}
