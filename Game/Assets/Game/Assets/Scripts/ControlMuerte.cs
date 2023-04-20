using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlMuerte : MonoBehaviour, MMEventListener<CorgiEngineEvent>, MMEventListener<PickableItemEvent>
{
    [SerializeField]
    private List<GameObject> corazones;
    private int vidas;
    private int contador_estrellas;

    // Start is called before the first frame update
    void Start()
    {
        vidas = corazones.Count;
    }

    public virtual void OnMMEvent(CorgiEngineEvent e)
    {
        if(e.EventType == CorgiEngineEventTypes.PlayerDeath)
        {
            if (vidas-1 >= 1)
            {
                vidas--;
                contador_estrellas= 0;
                corazones[vidas].SetActive(false);
            }
            if (vidas == 0)
            {
                Debug.Log("Game Over");
            }
        }
        Debug.Log (vidas);
        Debug.Log(e.EventType);
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Debug.Log("Pick");
        contador_estrellas++;

        if(contador_estrellas == 3 && vidas+1 <= corazones.Count)
        {
            corazones[vidas].SetActive(true);
            vidas++;
            contador_estrellas = 0;
        }
    }
}
