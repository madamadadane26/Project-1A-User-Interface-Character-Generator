using System.Collections.Generic;
using UnityEngine;

namespace CS583
{
    public class Player_Manager : MonoBehaviour
    {
        //variables to be referenced
        protected class PlayerInfo
        {
            public string charRace;
            public string charClass;
            public string charName;
            public string alignment;
            public float ability_Strength;
            public float ability_Constitution;
            public float ability_Dexterity;
            public float ability_Intelligence;
            public float ability_Charisma;
            public float ability_Wisdom;
            public int expCurrent;
            public int expMax;
            public int hpCurrent;
            public int hpMax;
            public int armorClass;
            public int walkingSpeed;
            public int runningSpeed;
            public int jumpHeight;

            //empty list for item list
            public List<string> itemList = new List<string>() { };
        }
    }

}
