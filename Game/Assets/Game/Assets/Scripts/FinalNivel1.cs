using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class FinalNivel : MonoBehaviour, MMEventListener<MMGameEvent>
{
    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();
    }
    public virtual void OnMMEvent(MMGameEvent e)
    {
        Debug.Log(e.EventName);
        
        if (e.EventName == "FinNivel")
        {
            SceneManager.LoadScene("Nivel 2", LoadSceneMode.Single);
        }
        
    }
}

