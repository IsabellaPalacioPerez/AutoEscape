using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlPickUp1 : MonoBehaviour, MMEventListener<CorgiEngineEvent>, MMEventListener<PickableItemEvent>
{
    [SerializeField]
    private TMP_Text txt_contador_PickUp1;
    private int contador_PickUp1;

    public void Start()
    {
        
    }
    public virtual void OnMMEvent(CorgiEngineEvent e)
    {
        if (e.EventType == CorgiEngineEventTypes.PlayerDeath)
        {
            ResetearPuntaje();
        }       
    }
    public virtual void OnMMEvent(PickableItemEvent e)
    {
        if (contador_PickUp1 == 15)
        {
            MMEventManager.TriggerEvent(new MMGameEvent("15PU"));
            Debug.Log("Ya");
        }
    }
    public int CantidadPickUp1Recolectados()
    {
        return contador_PickUp1;
    }
    public void ActualizarPuntaje(int valor)
    {
        contador_PickUp1 += valor;
        ActualizarValorUI();
    }
    public void ResetearPuntaje()
    {
        contador_PickUp1 = 0;
        ActualizarValorUI();
    }
    public void ActualizarValorUI()
    {
        txt_contador_PickUp1.text = ""+ contador_PickUp1;
    }
    void OnEnable()
    {
        this.MMEventStartListening<CorgiEngineEvent>();
        this.MMEventStartListening<PickableItemEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<CorgiEngineEvent>();
        this.MMEventStopListening<PickableItemEvent>();
    }
}