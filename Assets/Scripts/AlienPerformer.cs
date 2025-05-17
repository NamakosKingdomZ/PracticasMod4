using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AlienPerformer : CircusShow
{
    //Public Attributes
    public string alienName;
    public string trick;


    //Private Attributes
    private float _energyLevel;
    
    public AlienPerformer(string alienName, string trick, int _energyLevel = 100)
    {
        this.alienName = alienName;
        this.trick = trick;
       this._energyLevel = _energyLevel;
    }
   


    public void PerformTrick(float gravity)
    {
        Debug.Log(alienName + "va a realizar" + trick + "con una gravedad de" + gravity);

        float energyUsed = gravity * 15f;
        _energyLevel = _energyLevel - energyUsed;

        Debug.Log($"{alienName} ahora tiene {_energyLevel} decimal energia.");

    }

    public float GetEnergyLevel()
    {
        return _energyLevel;
    }

}
