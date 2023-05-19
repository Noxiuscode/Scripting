using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class ControlGatitos : MonoBehaviour
{

   


    [SerializeField]
    private TMP_Text txt_contador_gatitos;
    private int contador_gatitos;

    public void ActualizarGatitos(int valor)
    {
        contador_gatitos += valor;
        ActualizarValorUI();
    }

    public int ContadorGatitos()
    {
        return contador_gatitos;
    }

    public void ResetearPuntaje()
    {
        contador_gatitos = 0;
        ActualizarValorUI();
    }

    public void ActualizarValorUI()
    {
        txt_contador_gatitos.text = "" + contador_gatitos;

    }
}
