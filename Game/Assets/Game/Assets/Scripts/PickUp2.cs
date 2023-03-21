using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class PickUp2 : PickableItem
{
    private int Valor_Tiempo = 15;
    protected override void Pick(GameObject picker)
    {
        ControlTiempo.Instance.SumarTiempo(Valor_Tiempo);
    }
}

