using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTiempo_1 : MonoBehaviour
{
    private int contador;
    
    private void Start()
    {
        Debug.Log(contador);//hasta la existencia
        StartCoroutine(Contar());
    }

    IEnumerator Contar()
    {
        yield return new WaitForSecondsRealtime(1);
        contador++;
        Debug.Log(contador);
        StartCoroutine(Contar());
    }
}
