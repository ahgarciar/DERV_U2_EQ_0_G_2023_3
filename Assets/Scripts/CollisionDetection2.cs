using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection2 : MonoBehaviour
{
    [SerializeField] GameObject Comm_SpawnerContainer;
    CrearEnemigo ref_crearEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        ref_crearEnemigo = Comm_SpawnerContainer.GetComponent<CrearEnemigo>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;
        string name = obj.name;
        Debug.Log("Entro en colision con:" + name);

        if (!obj.CompareTag("No_Romper"))
        {
            Destroy(obj, 0.1f);
            if (obj.CompareTag("Enemy"))
            {
                ref_crearEnemigo.isCreated = false;
            }
            
        }

        //Tarea:  Random

    }

    private void OnCollisionStay(Collision collision)
    {
        GameObject obj = collision.gameObject;
        string name = obj.name;
        Debug.Log("Permance en colision con:" + name);
    }

    private void OnCollisionExit(Collision collision)
    {
        GameObject obj = collision.gameObject;
        string name = obj.name;
        Debug.Log("Sale de colision con:" + name);
    }

}
