using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDoorSkins : MonoBehaviour
{
    public GameObject skinsPanel;

    private bool inDoor=false;

    public GameObject player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            skinsPanel.gameObject.SetActive(true);
            inDoor =true;

        
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        skinsPanel.gameObject.SetActive(false);
       
        inDoor = false;
    }

    public void SetPlayerDino()
    {
        PlayerPrefs.SetString("PlayerSelected","Dinodino");
        Debug.Log("Has cambiado a dinodino");
        ResetPlayerSkin();


    }

    public void SetPlayerMoradino()
    {
        PlayerPrefs.SetString("PlayerSelected", "Moradino");
        Debug.Log("Has cambiado a Moradino");
        ResetPlayerSkin();


    }

    void ResetPlayerSkin()
    {

        skinsPanel.gameObject.SetActive(false);
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu();

    }
}
