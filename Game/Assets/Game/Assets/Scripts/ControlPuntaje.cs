using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuntaje : MonoBehaviour
{
    [SerializeField]
    private GameObject ui_Puntaje;
    private ControlPickUp1 control_Pickup1;
    public static ControlPuntaje Instance { get; private set; }

    public void Start()
    {
        control_Pickup1 = ui_Puntaje.GetComponent<ControlPickUp1>();
    }
    public void ActualizarPuntaje(int valor_Pickup1)
    {
        control_Pickup1.ActualizarPuntaje(valor_Pickup1);
    }

    public void ResetearPuntaje()
    {
        control_Pickup1.ResetearPuntaje();
    }
    public void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(this);} else { Instance=this; }
    }

}
