using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;


public class PickUp1 : PickableItem
{
    [SerializeField]
    private GameObject ui_puntaje;
    [SerializeField]
    private int valor_pickUp1;
    private ControlPickUp1 control_PickUp1;

    public void Start()
    {
        control_PickUp1 = ui_puntaje.GetComponent<ControlPickUp1>();
    }

    protected override void Pick(GameObject picker)
    {
        control_PickUp1.ActualizarPuntaje(valor_pickUp1);
    }
}
