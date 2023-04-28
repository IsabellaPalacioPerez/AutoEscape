using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JugarBoton : MonoBehaviour
{
    public void OnPressPlay()
    {
        SceneManager.LoadScene("Nivel 1", LoadSceneMode.Single);
    }

    public void OnPressInstrucciones()
    {
        SceneManager.LoadScene("Instrucciones", LoadSceneMode.Single);
    }

    public void OnPressCreditos()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
    }

}
