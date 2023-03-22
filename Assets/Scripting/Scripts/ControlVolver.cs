using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlVolver : MonoBehaviour
{
    public void OnPressVolver()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
