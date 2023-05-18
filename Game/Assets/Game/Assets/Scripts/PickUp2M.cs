using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class PickUp2M : PickableItem
{
    private int Valor_Tiempo = 20;
    protected override void Pick(GameObject picker)
    {
        ControlTiempoM.Instance.SumarTiempo(Valor_Tiempo);
    }
}