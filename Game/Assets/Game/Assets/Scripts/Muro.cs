using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class Muro : MonoBehaviour, MMEventListener<MMGameEvent>
{

    [SerializeField]
    private GameObject muro;
    private ControlPickUp1 ctrlPickUp1;
    
    public void Start()
    {
        
    }
    public virtual void OnMMEvent(MMGameEvent e)
    {
        if (e.EventName == "15PU")
        {
            CambiarEstado(false);
        }        
    }
    public void Update()
    {
       
       /* if (ctrlPickUp1.CantidadPickUp1Recolectados() == 15)
        {
            CambiarEstado(false);
        }*/
    }
    public void CambiarEstado(bool estado)
    {
        
        muro.SetActive(estado);
    }
    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();
    }
}
