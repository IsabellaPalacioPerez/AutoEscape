using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtrasBoton : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnPressAtras()
    {
        SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
    }
}
