using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class LogrosJuego : MMAchievementRules , MMEventListener<PickableItemEvent> 
{
   
    public virtual void OnMMEvent (PickableItemEvent pickableItemEvent) 
    {
        Debug.Log("Recogio algo");
        if (pickableItemEvent.PickedItem != null)
        {
            if (pickableItemEvent.PickedItem.GetComponent<Coin>() != null)
            {
                
            }
            if (pickableItemEvent.PickedItem.GetComponent<Stimpack>() != null)
            {

            }
        }
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        this.MMEventStartListening<PickableItemEvent>();
    }
    protected override void OnDisable()
    {
        base.OnDisable();
        this.MMEventStopListening<PickableItemEvent>();
    }
    
}
