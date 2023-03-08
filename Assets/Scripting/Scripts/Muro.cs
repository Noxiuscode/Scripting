using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour
{

    [SerializeField]
    private GameObject muro;
    private ControlGatitos control_gatitos;
    void Start()
    {
        Debug.Log(this.transform.parent);   
    }

    // Update is called once per frame
    public void CambiarEstado(bool estado)
    {
        muro.SetActive(estado);
    }
}
