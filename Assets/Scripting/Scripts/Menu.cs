using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void OnPressJugar()
    {
        SceneManager.LoadScene("Mundo", LoadSceneMode.Single);

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
