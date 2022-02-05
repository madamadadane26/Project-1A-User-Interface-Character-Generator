using System.Collections.Generic;
using UnityEngine;

public class CharacterVariables : MonoBehaviour
{
    //protected class containing variables to be referenced
    protected class PlayerInfo
    {
        string charRace;
        string charClass;
        string charName;
        string alignment;
        float ability_Strength;
        float ability_Constitution;
        float ability_Dexterity;
        float ability_Intelligence;
        float ability_Charisma;
        float ability_Wisdom;
        int expCurrent;
        int expMax;
        int hpCurrent;
        int hpMax;
        int armorClass;
        int walkingSpeed;
        int runningSpeed;
        int jumpHeight;

        //empty list for item list
        public List<string> itemList = new List<string>() { };
    }
}

