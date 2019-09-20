using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Complete
{
    public class HUDManager : MonoBehaviour
    {
        public TankManager[] Players;
        public int SelectedTank;

        // Start is called before the first frame update
        void Start()
        {
            SelectedTank = 2;
        }


        public void SetSelectedTank(int tank)
        {
            SelectedTank = tank;
        }

        public void SetTankColour(GameObject button)
        {
        Players[SelectedTank].SetColour(button.GetComponent<Image>().color);
        }
    }
}
