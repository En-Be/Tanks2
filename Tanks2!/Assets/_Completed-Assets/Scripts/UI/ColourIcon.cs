using System;
using UnityEngine;
using UnityEngine.UI;

namespace Complete
{
    [Serializable]
    public class ColourIcon
    {
        public Color Colour;
        [HideInInspector] public HUDManager HUDM;
        [HideInInspector] public GameObject m_Instance;
        [HideInInspector] public Image Icon;
        [HideInInspector] public Button button;


        public void Setup()
        {
            HUDM = m_Instance.gameObject.GetComponentInParent<HUDManager>();
            Icon = m_Instance.gameObject.GetComponent<Image>();
            button = m_Instance.gameObject.GetComponent<Button>();

            Icon.color = Colour;
            button.onClick.AddListener(ChangeColour);
        }

        public void ChangeColour()
        {
            HUDM.SetTankColour(Colour);
        }
    }
}
