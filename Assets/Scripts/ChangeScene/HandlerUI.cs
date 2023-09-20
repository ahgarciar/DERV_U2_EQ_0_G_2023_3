using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandlerUI : MonoBehaviour
{


    public static void CambiarEscena(int index) {
        SceneManager.LoadScene(index);
    }


}
