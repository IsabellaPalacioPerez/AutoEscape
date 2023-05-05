using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTiempo_1 : MonoBehaviour
{
    private int contador;
    
    private void Start()
    {
        StartCoroutine(Contar());
    }

    IEnumerator Contar()
    {
        yield return new WaitForSecondsRealtime(1);
        contador++;
        StartCoroutine(Contar());
    }
}
