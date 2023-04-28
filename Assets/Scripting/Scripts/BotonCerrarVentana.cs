using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class BotonCerrarVentana : MonoBehaviour
{
    public void OnCerrarVentana()
    {
        VentanaSingleton.Instance.Ventana.SetActive(true);
        GameManager.Instance.UnPause();

    }
}
