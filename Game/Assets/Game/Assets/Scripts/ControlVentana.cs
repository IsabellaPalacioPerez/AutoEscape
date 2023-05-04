using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlVentana : MonoBehaviour, MMEventListener<MMGameEvent>
{
    public void OnMMEvent(MMGameEvent eventType)
    {
        if (eventType.EventName == "AbrirVentanaEvent")
        {
            //Ventana.SetActive(true);
            VentanaSingleton.Instance.Ventana.SetActive(true);
            GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
            StartCoroutine(CerrarVentana());
        }
    }

    IEnumerator CerrarVentana()
    {
        Debug.Log("Cerrar Ventana");
        yield return new WaitForSecondsRealtime(5);
        Debug.Log("La ventana se cerro");
        GameManager.Instance.UnPause();
        VentanaSingleton.Instance.Ventana.SetActive(false);
    }

    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }
    void OnDisable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }
}
