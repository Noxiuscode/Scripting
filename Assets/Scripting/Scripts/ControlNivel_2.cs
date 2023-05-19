using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine.UI;


public class ControlNivel_2 : MonoBehaviour
{

    public Text levelCleared;

    public Text totalGatitos;

    public Text gatitosRecolectados;

    private int totalGatitosInLevel;
    [SerializeField]
    private ControlGatitos control_gatitos;
    // Start is called before the first frame update
    void Start()
    {
        totalGatitosInLevel = transform.childCount;
    }

    // Update is called once per frame
    public void Update()
    {
        AllGatitosCollected();

        totalGatitos.text = totalGatitosInLevel.ToString();
        gatitosRecolectados.text = transform.childCount.ToString();

    }

    public void AllGatitosCollected()
    {
        if (transform.childCount == 0)
        {
            levelCleared.gameObject.SetActive(true);
            Debug.Log("No hay mas gatitos");
            Invoke("ChangeScene", 2);

        }
    }

    void ChangeScene()
    {
        MMSceneLoadingManager.LoadScene("Juego Finalizado");
    }
}
