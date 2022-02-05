using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CS583
{
    public class UI_Controller : MonoBehaviour
    {
        public Text CharNameout;
        public InputField CharNameIn;
        public Text textOut_Strength;

        void Start()
        {

            CharNameout.text = "Player McLamer";

        }

        public void CallBack_EditEnd()
        {
            Debug.Log("CallBack_EditEnd was called");
        }

        public void CallBack_Roll_Strength()
        {
            int strstrength = Random.Range(1, 18);
            textOut_Strength.text = strstrength.ToString();

        }
    }

}
