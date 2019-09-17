using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankColour : MonoBehaviour
{
    public int m_PlayerNumber = 1;              // Used to identify which tank belongs to which player.  This is set by this tank's manager.
    public Color m_PlayerColor;                             // This is the color this tank will be tinted.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Set(Color colour)
    {
        Debug.Log(colour);

        // Get all of the renderers of the tank.
        MeshRenderer[] renderers = gameObject.GetComponentsInChildren<MeshRenderer> ();

        // Go through all the renderers...
        for (int i = 0; i < renderers.Length; i++)
        {
            // ... set their material color to the color specific to this tank.
            renderers[i].material.color = colour;
        }
    }
}
