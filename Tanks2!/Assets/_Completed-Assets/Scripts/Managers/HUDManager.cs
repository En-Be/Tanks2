using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Complete
{
    public class HUDManager : MonoBehaviour
    {
        public TankManager PlayerOne;
        public TankManager PlayerTwo;
        public int SelectedTank;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void SetSelectedTank(int tank)
        {
            SelectedTank = tank;
        }

        public void SetTankColour(GameObject button)
        {
            if(SelectedTank == 1)
            {
                PlayerOne.m_Colour.Set(button.GetComponent<Image>().color);
                Debug.Log(button.GetComponent<Image>().color);
            }
            else
            {
                PlayerTwo.m_Colour.Set(button.GetComponent<Image>().color);
            }
        }
    }
}
