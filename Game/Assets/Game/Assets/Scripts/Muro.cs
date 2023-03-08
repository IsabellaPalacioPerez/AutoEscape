using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour
{

    [SerializeField]
    private GameObject muro;
    private ControlPickUp1 controlPickUp1;
    
    public void Start()
    {
        controlPickUp1 = this.transform.parent.GetComponent<ControlPickUp1>();
        
    }
    public void Update()
    {
        if (controlPickUp1.ContadorPickup() == 15)
        {
            CambiarEstado(false);
        }

    }
    public void CambiarEstado(bool estado)
    {
        muro.SetActive(estado);
    }
}
