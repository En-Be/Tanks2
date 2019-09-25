using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Complete
{
    public class HUDManager : MonoBehaviour
    {
        public TankManager[] Players;
        public int SelectedTank;

        public GameObject IconsHolder;
        public GameObject ColourIconButton;
        public ColourIcon[] Colours;

        // Start is called before the first frame update
        void Start()
        {
            SelectedTank = 2;
            Setup();
        }

        private void Setup()
        {
            for (int i = 0; i < Colours.Length; i++)
            {
                Colours[i].HUDM = this;
                Colours[i].m_Instance = Instantiate(ColourIconButton) as GameObject;
                Colours[i].m_Instance.transform.SetParent(IconsHolder.transform);
                Colours[i].Setup();
            }
        }

        public void SetSelectedTank(int tank)
        {
            SelectedTank = tank;
        }

        public void SetTankColour(Color button)
        {
            Players[SelectedTank].SetColour(button);
        }
    }
}
