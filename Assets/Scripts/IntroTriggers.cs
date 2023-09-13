using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IntroTriggers : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textRespuesta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        string name = obj.name;
        Debug.Log("Entra en Trigger con: " + name);
        textRespuesta.text = name + "(Entra)";
    }

    private void OnTriggerStay(Collider other)
    {
        GameObject obj = other.gameObject;
        string name = obj.name;
        Debug.Log("Permanece en Trigger con: " + name);
        textRespuesta.text = name + "(Permanece)";
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject obj = other.gameObject;
        string name = obj.name;
        Debug.Log("Sale de Trigger con: " + name);
        textRespuesta.text = name + "(Sale)";
    }

}
