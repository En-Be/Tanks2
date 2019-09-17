using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankColour : MonoBehaviour
{
    public int m_PlayerNumber = 1;              // Used to identify which tank belongs to which player.  This is set by this tank's manager.
    // public Color m_PlayerColor;                 // This is the color this tank will be tinted.
    public Image m_HUDIcon;

    private void Awake()
    {

    }

    public void Set(Color colour)
    {
        // Debug.Log(colour);

        // Get all of the renderers of the tank.
        MeshRenderer[] renderers = gameObject.GetComponentsInChildren<MeshRenderer> ();

        // Go through all the renderers...
        for (int i = 0; i < renderers.Length; i++)
        {
            // ... set their material color to the color specific to this tank.
            renderers[i].material.color = colour;
        }

        SetColourUI(colour);
    }

    private void SetColourUI(Color colour)
    {
        m_HUDIcon.color = colour;
    }
}
