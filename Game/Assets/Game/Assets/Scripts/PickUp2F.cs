using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class PickUp2F : PickableItem
{
    private int Valor_Tiempo = 25;
    protected override void Pick(GameObject picker)
    {
        ControlTiempoF.Instance.SumarTiempo(Valor_Tiempo);
    }
}