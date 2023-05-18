using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine.SceneManagement;

public class FinNivelN2F : PickableItem
{
    protected override void Pick(GameObject picker)
    {
        MMGameEvent.Trigger("FinNivel");
        SceneManager.LoadScene("Nivel3-Facil", LoadSceneMode.Single);

    }
}
