using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlVentana : MonoBehaviour, MMEventListener<MMGameEvent>
{
    static bool vendeath = false;
    static int tiempo = 0;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.Space))
        {
            tiempo = 0;
            StartCoroutine(CerrarVentana());
        }
    }
    public void OnMMEvent(MMGameEvent eventType)
    {
        if (vendeath == false)
        {
            if (eventType.EventName == "AbrirVentanaEvent")
            {
                //Ventana.SetActive(true);
                VentanaSingleton.Instance.Ventana.SetActive(true);
                GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
                tiempo = 5;
                StartCoroutine(CerrarVentana());
                vendeath= true;
            }
        }     
    }

    IEnumerator CerrarVentana()
    {
        yield return new WaitForSecondsRealtime(tiempo);
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
