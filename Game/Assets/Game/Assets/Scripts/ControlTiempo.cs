using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;


public class ControlTiempo : MonoBehaviour, MMEventListener<CorgiEngineEvent>
{
    [SerializeField]
    private TMP_Text txt_contador_Tiempo;
    private int contador_Tiempo = 60;
    private int i = 0;
    public static ControlTiempo Instance { get; private set; }


    void Start()
    {
        Invoke("TerminarTemporizador", 60);

        InvokeRepeating("ActualizarTiempo", 0f,1f);

        
    }
    public virtual void OnMMEvent(CorgiEngineEvent e)
    {
        if (e.EventType == CorgiEngineEventTypes.PlayerDeath)
        {
            Invoke("Muerte", 2);
        }
    }
    public void Muerte()
    {
        contador_Tiempo = 60;
        ActualizarValorUI();
    }

    public void ActualizarTiempo()
    {
         contador_Tiempo -= 1;
         ActualizarValorUI();
    }
    public void SumarTiempo(int valor)
    {
        contador_Tiempo += valor;
        ActualizarValorUI();
    }
    public void ActualizarValorUI()
    {
        txt_contador_Tiempo.text = "" + contador_Tiempo;
    }
    void TerminarTemporizador()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
        Debug.Log("Se termino el tiempo");

    }
    public void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(this); } else { Instance = this; }
    }
    void OnEnable()
    {
        this.MMEventStartListening<CorgiEngineEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<CorgiEngineEvent>();
    }
}
