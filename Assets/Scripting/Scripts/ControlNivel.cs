using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;


public class ControlNivel : MonoBehaviour
{
    [SerializeField]
    private ControlGatitos control_gatitos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if(control_gatitos.ContadorGatitos()==2)
        {
            MMSceneLoadingManager.LoadScene("Nivel2");
        }
    }
}
