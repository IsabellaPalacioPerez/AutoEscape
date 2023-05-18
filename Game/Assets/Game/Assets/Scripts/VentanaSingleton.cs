using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentanaSingleton : MonoBehaviour
{
    [SerializeField]
    private GameObject ventana;

    public static VentanaSingleton Instance { get; private set; }
    public GameObject Ventana { get => ventana; set => ventana = value; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}

