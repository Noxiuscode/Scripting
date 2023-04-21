using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlMuerte : MonoBehaviour, MMEventListener<CorgiEngineEvent>, MMEventListener<PickableItemEvent>, MMEventListener<MMDamageTakenEvent>
{

    public enum ControlMuerteTypes
    {
        GameOver
    }

  
    [SerializeField]

    private List<GameObject> corazones;

    private int vidas;

    private int contador_estrellas;

    [SerializeField]

    private int total_estrellas;

    [SerializeField]

    private int tolerancia_colision;

    private int tolerancia_colision_inicial;





    public void Start()
    {
        vidas = corazones.Count;
        tolerancia_colision_inicial = tolerancia_colision;

       

    }

    public virtual void OnMMEvent(CorgiEngineEvent e)
    {
        if (e.EventType == CorgiEngineEventTypes.PlayerDeath)
        {


            QuitarVida();

        }

        Debug.Log(vidas);
        Debug.Log(e.EventType);
    }

    // Update is called once per frame
    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Debug.Log("Pick");

        contador_estrellas++;

        Debug.Log("contador de estrellas: " + contador_estrellas + " vidas " + vidas);


        if (contador_estrellas == 3 && vidas + 1 <= corazones.Count)
        {
            corazones[vidas].SetActive(true);
            vidas++;
            contador_estrellas = 0;

        }
    }

    public virtual void OnMMEvent(MMDamageTakenEvent e)
    {
       
        if(--tolerancia_colision==0)
        {
            QuitarVida();
            tolerancia_colision = tolerancia_colision_inicial;
            

        }
        e.Instigator.SetActive(false);




    }

    public void QuitarVida()
    {

        if(vidas-1 >= 0)
        {
            contador_estrellas = 0;
            vidas--;
            corazones[vidas].SetActive(false);
            Debug.Log("Player death");


        }

        if (vidas == 0)
        {
            Debug.Log("Game over");
            MMEventManager.TriggerEvent(new MMGameEvent("GameOver"));

        }
    }


    void OnEnable()
    {
        this.MMEventStartListening<CorgiEngineEvent>();
        this.MMEventStartListening<PickableItemEvent>();
        this.MMEventStartListening<MMDamageTakenEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<CorgiEngineEvent>();
        this.MMEventStopListening<PickableItemEvent>();
        this.MMEventStopListening<MMDamageTakenEvent>();
    }
}
