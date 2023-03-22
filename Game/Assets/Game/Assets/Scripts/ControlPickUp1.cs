using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlPickUp1 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text txt_contador_PickUp1;
    private int contador_PickUp1;

    public void Start()
    {
        
    }
    public int CantidadPickUp1Recolectados()
    {
        return contador_PickUp1;
    }
    public void ActualizarPuntaje(int valor)
    {
        contador_PickUp1 += valor;
        ActualizarValorUI();
    }
    public void ResetearPuntaje()
    {
        contador_PickUp1 = 0;
        ActualizarValorUI();
    }
    public void ActualizarValorUI()
    {
        txt_contador_PickUp1.text = ""+ contador_PickUp1;
    }
}