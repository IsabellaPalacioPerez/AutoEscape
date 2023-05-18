using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine.SceneManagement;


public class PuertaFinal : PickableItem
{
    protected override void Pick(GameObject picker)
    {
        MMGameEvent.Trigger("FinNivel");
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);

    }
}
