using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    private bool inDoor = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inDoor=false;
    }

    private void Update()
    {
        if (inDoor && Input.GetKey("a"))
        {
            SceneManager.LoadScene("Nivel1");

        }
       

    }
}
