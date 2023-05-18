using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modo : MonoBehaviour
{
    public void OnPressPlay()
    {
        SceneManager.LoadScene("Nivel1-Facil", LoadSceneMode.Single);
    }

    public void OnPressInstrucciones()
    {
        SceneManager.LoadScene("Nivel1-Dificil", LoadSceneMode.Single);
    }

    public void OnPressCreditos()
    {
        SceneManager.LoadScene("Nivel1-Medio", LoadSceneMode.Single);
    }

}
