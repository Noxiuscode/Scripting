using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;


public class EscucharFinJuego : MonoBehaviour, MMEventListener<MMGameEvent>
{


    public virtual void OnMMEvent(MMGameEvent e)
    {
        Debug.Log(e.EventName);


    }

    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }

     void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();
    }
}
