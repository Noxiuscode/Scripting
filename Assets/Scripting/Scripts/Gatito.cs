using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Gatito : PickableItem //Sobreescribir el metodo pick
{
    [SerializeField]
    private GameObject ui_puntaje;
    [SerializeField]
    private int valor_gatito;
    private ControlGatitos control_gatitos;

    void Start()
    {
        control_gatitos = ui_puntaje.GetComponent<ControlGatitos>();
    }
    protected override void Pick(GameObject picker)
    {
       // control_gatitos.ActualizarPuntaje(valor_gatito);
    }
}
