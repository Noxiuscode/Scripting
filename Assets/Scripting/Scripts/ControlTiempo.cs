using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTiempo : MonoBehaviour
{
    private int contador;


    private void Start()
    {

        //StartCoroutine(Contar());
    }

    IEnumerator Contar()
    {
        

        yield return new WaitForSecondsRealtime(1);
        contador++;
        Debug.Log(contador);

        if(contador<10)
        {
            StartCoroutine(Contar());
        }
        else
        {

        }

    }
}
