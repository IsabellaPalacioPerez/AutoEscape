using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine.SceneManagement;

public class FinNivelN2D : PickableItem
{
    protected override void Pick(GameObject picker)
    {
        MMGameEvent.Trigger("FinNivel");
        SceneManager.LoadScene("Nivel3-Dificl", LoadSceneMode.Single);

    }
}
