using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;


public class PickUp1 : PickableItem
{
    [SerializeField]
    private int Valor_PickUp1;

    protected override void Pick(GameObject picker)
    {
        ControlPuntaje.Instance.ActualizarPuntaje(Valor_PickUp1);
    }
}
