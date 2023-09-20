using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorConMB : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt_contador;
    int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {        
        txt_contador.text = contador++.ToString();        
    }
}
