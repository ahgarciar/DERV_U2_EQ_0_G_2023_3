using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorCoroutine : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt_contador;
    int contador = 0;   

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        StopAllCoroutines();
        StartCoroutine("counter_routine");
        //StartCoroutine(counter_routine);
    }

    // Update is called once per frame
    void Update()
    {        
    }

    IEnumerator counter_routine() {
        while (true)
        {                     
           txt_contador.text = contador++.ToString();
            Debug.Log(contador);
            yield return new WaitForSeconds(1f);
        }
    }

}
