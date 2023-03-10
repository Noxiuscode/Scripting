using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuntaje : MonoBehaviour
{
    [SerializeField]
    private GameObject ui_puntaje;
    private ControlGatitos control_gatitos;

    public static ControlPuntaje Instance { get; private set; }

    void Start()
    {
      control_gatitos = ui_puntaje.GetComponent<ControlGatitos>();    
    }

    public void ActualizarPuntaje(int valor_gatito)
    {
        control_gatitos.ActualizarGatitos(valor_gatito); 
    }

    public void ResetearPuntaje()
    {
        control_gatitos.ResetearPuntaje();
    }

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }

        else
        {
            Instance = this;
        }
    }

}
