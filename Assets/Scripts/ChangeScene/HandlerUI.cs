using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandlerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt_usuario;

    string usuario;

    public void CambiarEscena(int index) {

        Scene temp = SceneManager.GetActiveScene();
        if (temp.buildIndex == 3)
        {
            usuario = txt_usuario.text;
            PlayerPrefs.SetString("user", usuario);
            Debug.Log("Nombre Guardado: " + PlayerPrefs.GetString("user"));
        }


        SceneManager.LoadScene(index);       
    }

    public void Start()
    {
        Scene temp = SceneManager.GetActiveScene();
        if (temp.buildIndex == 5)

            usuario = PlayerPrefs.GetString("user");

            txt_usuario.text  = usuario; 
    }
    
}
