using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : CircusShow
{
    //Public Attributes
    public string planetName;
    public float gravity;
    
    //Private Attributes
    private bool IsHostile;
    
    
    public Planet(string planetName, float gravity, bool isHostile)
    {
        this.planetName = planetName;
        this.gravity = gravity;
        this.IsHostile = isHostile;
    }

    public bool GetIsHostile()
        { return IsHostile; }







}


