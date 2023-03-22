using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlTiempo : MonoBehaviour
{
    [SerializeField]
    private TMP_Text txt_contador_Tiempo;
    private int contador_Tiempo = 60;
    private int i = 0;
    public static ControlTiempo Instance { get; private set; }


    void Start()
    {
        Invoke("TerminarTemporizador", 60f);

        InvokeRepeating("ActualizarTiempo", 0f,1f);
    }

    public void ActualizarTiempo()
    {
            contador_Tiempo -= 1;
            ActualizarValorUI();
    }
    public void SumarTiempo(int valor)
    {
        contador_Tiempo += valor;
        ActualizarValorUI();
    }
    public void ActualizarValorUI()
    {
        txt_contador_Tiempo.text = "" + contador_Tiempo;
    }
    void TerminarTemporizador()
    {
        Debug.Log("Se termin� el tiempo");

    }
    public void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(this); } else { Instance = this; }
    }
}
