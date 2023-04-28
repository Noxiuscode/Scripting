using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class VentanaSingleton : MonoBehaviour
{
    [SerializeField]

    private GameObject ventana;
    public static VentanaSingleton Instance { get; private set; }
    public GameObject Ventana { get => ventana; set => ventana = value; }

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }


}
