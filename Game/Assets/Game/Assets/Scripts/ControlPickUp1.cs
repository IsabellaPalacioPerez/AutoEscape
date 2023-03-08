using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlPickUp1 : MonoBehaviour
{
  
    [SerializeField]
    private TMP_Text txt_contador_pickUp1;
    private int contador_pickUp1;

    public void ActualizarPuntaje(int valor)
    {
        contador_pickUp1 += valor;
        ActualizarValorUI();

     
    }

    public void ActualizarValorUI()
    {
        txt_contador_pickUp1.text = "" + contador_pickUp1;
    }
    public void ActualizarContador(int valor)
    {
        contador_pickUp1 += valor;
    }
    public int ContadorPickup()
    {
        return contador_pickUp1;
    }
}
