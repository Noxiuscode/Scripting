using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlAleatorio : MonoBehaviour
{
    [SerializeField]

    private List<Gatito> gatitos;

    void Start()
    {

    }

    public void OcultarMonedas()
    {
        for(int i=0; i<gatitos.Count; i++)
        {
            gatitos[i];
        }
    }
}
