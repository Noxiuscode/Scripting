using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine.UI;


public class ControlNivel : MonoBehaviour
{

    public Text levelCleared;
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
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 2);
            
        }
    }

    void ChangeScene()
    {
        MMSceneLoadingManager.LoadScene("Nivel2");
    }
}
