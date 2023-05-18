using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosSingleton : MonoBehaviour
{
    [SerializeField]
    private GameObject puntos;

    public static PuntosSingleton Instance { get; private set; }
    public GameObject Puntos { get => puntos; set => puntos = value; }

    public void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(this); } else { Instance = this; }
    }
}

