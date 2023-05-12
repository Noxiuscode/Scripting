using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMaxPower : MonoBehaviour
{
    public static ControladorMaxPower Instance;

    [SerializeField] private float puntaje;

    private void Awake()
    {
        if(ControladorMaxPower.Instance == null)
        {
            ControladorMaxPower.Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(gameObject);

        }
    }

    public void SumarPuntos(float puntos)
    {
        puntaje += puntos;
    }
}
