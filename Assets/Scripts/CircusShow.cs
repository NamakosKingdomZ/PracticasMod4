using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircusShow : MonoBehaviour 
{
    public AlienPerformer Performer;
    public Planet ShowPlanet;

    private int AudienceCount;




    private void Start()
    {
        StarShow();
    }
    public void Initialize(AlienPerformer performer, Planet planet)
    {
        Performer = performer;
        ShowPlanet = planet;

        //Si el planeta es hostil, menos público
        AudienceCount = ShowPlanet.GetIsHostile() ? Random.Range(0, 10) : Random.Range(0, 10);


    }

    public void StarShow()
    {
        Debug.Log($"Comienza la funcion en {ShowPlanet.planetName} con {AudienceCount} espectadores.");

        Performer.PerformTrick(ShowPlanet.gravity);

        Debug.Log($"La función ha terminado.");

    }


    public int GetAudienceCount()
        { return AudienceCount; }
    


}
