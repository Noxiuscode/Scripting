using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Gatito : PickableItem //Sobreescribir el metodo pick
{
    [SerializeField]
    private int valor_gatito;

    protected override void Pick(GameObject picker)
    {
        ControlPuntaje.Instance.ActualizarPuntaje(valor_gatito);
    }



}
