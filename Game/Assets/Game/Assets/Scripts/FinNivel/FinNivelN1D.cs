using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine.SceneManagement;

public class FinNivelN1D : PickableItem
{
    protected override void Pick(GameObject picker)
    {
        MMGameEvent.Trigger("FinNivel");
        SceneManager.LoadScene("Nivel2-Dificl", LoadSceneMode.Single);

    }
}
