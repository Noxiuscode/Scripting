using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;

public class Menu : MonoBehaviour
{

   void Update()
   {
        if(Input.GetButtonDown("Submit"))
        {
            Debug.Log("click");
        }
   }
   public void OnPressJugar()
    {
        SceneManager.LoadScene("Nivel1", LoadSceneMode.Single);

    }

    public void OnPressInstrucciones()
    {
        Debug.Log("Instrucciones");
        SceneManager.LoadScene("Instrucciones",LoadSceneMode.Single);

    }

    public void OnPressCreditos()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
    }

    public void OnPressControles()
    {
        SceneManager.LoadScene("Controles", LoadSceneMode.Single);
    }
}
