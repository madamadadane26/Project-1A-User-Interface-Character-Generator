using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Random = System.Random;
using System.Linq;

namespace CS583
{
    public class UI_Controller : Player_Manager
    {

        public Text CharNameout;
        public InputField CharNameIn;

        public Dropdown dropdownRace;
        public Dropdown dropdownClass;

        public Text race_Description;
        public Text class_Description;



        List<string> raceListdesc = new List<string>() {
        "Character Description",
        "Your draconic heritage manifests in a variety of traits you share with other dragonborn.",
        "Your dwarf character has an assortment of abilities, part and parcel of dwarven nature.",
        "Your elf character has a variety of natural abilities, the result of thousands of years of elven refinement.",
        "Your gnome character has certain characteristics in common with all other gnomes.",
        "Your half-elf character has some qualities in common with elves and some that are unique to half-elves.",
        "Your half-orc character has certain traits deriving from your orc ancestry.",
        "Your halfling character has a number of traits in common with all other halflings.",
        "It's hard to make generalizations about humans, but your human character has these traits.",
        "Tieflings share certain racial traits as a result of their infernal descent." };

        List<string> classListdesc = new List<string>() {
        "Class Description",
        "In battle, you fight with primal ferocity. For some barbarians, rage is a means to an end–that end being violence.",
        "Whether singing folk ballads in taverns or elaborate compositions in royal courts, bards use their gifts to hold audiences spellbound.",
        "Clerics act as conduits of divine power.",
        "Druids venerate the forces of nature themselves. Druids holds certain plants and animals to be sacred, and most druids are devoted to one of the many nature deities",
        "Different fighters choose different approaches to perfecting their fighting prowess, but they all end up perfecting it.",
        "Coming from monasteries, monks are masters of martial arts combat and meditators with the ki living forces.",
        "Paladins are the ideal of the knight in shining armor; they uphold ideals of justice, virtue, and order and use righteous might to meet their ends.",
        "Acting as a bulwark between civilization and the terrors of the wilderness, rangers study, track, and hunt their favored enemies.",
        "Rogues have many features in common, including their emphasis on perfecting their skills, their precise and deadly approach to combat, and their increasingly quick reflexes.",
        "An event in your past, or in the life of a parent or ancestor, left an indelible mark on you, infusing you with arcane magic. As a sorcerer the power of your magic relies on your ability to project your will into the world.",
        "You struck a bargain with an otherworldly being of your choice: the Archfey, the Fiend, or the Great Old One who has imbued you with mystical powers, granted you knowledge of occult lore, bestowed arcane research and magic on you and thus has given you facility with spells",
        "The study of wizardry is ancient, stretching back to the earliest mortal discoveries of magic. As a student of arcane magic, you have a spellbook containing spells that show glimmerings of your true power which is a catalyst for your mastery over certain spells."};


        List<string> alignmentList = new List<string>()
        {
        };
        
        private Text t_Strength;
        private Button b_Roll_Strength;

        private Text t_Intelligence;
        private Button b_Roll_Intelligence;

        private Text t_Dexterity;
        private Button b_Roll_Dexterity;

        private Text t_Charisma;
        private Button b_Roll_Charisma;

        private Text t_Constitution;
        private Button b_Roll_Constitution;

        private Text t_Wisdom;
        private Button b_Roll_Wisdom;

        PlayerInfo pm = new PlayerInfo();


        void Start()
        {

            CharNameout.text = "Player McLamer";
            initUIReferences();


        }

        private void initUIReferences()
        {
            t_Wisdom = GameObject.Find("t_Wisdom").GetComponent<Text>();
            b_Roll_Wisdom = GameObject.Find("b_Roll_Wisdom").GetComponent<Button>();
            b_Roll_Wisdom.onClick.AddListener(CallBack_Roll_Wisdom);

            t_Strength = GameObject.Find("t_Strength").GetComponent<Text>();
            b_Roll_Strength = GameObject.Find("b_Roll_Strength").GetComponent<Button>();
            b_Roll_Strength.onClick.AddListener(CallBack_Roll_Strength);

            t_Dexterity = GameObject.Find("t_Dexterity").GetComponent<Text>();
            b_Roll_Dexterity = GameObject.Find("b_Roll_Dexterity").GetComponent<Button>();
            b_Roll_Dexterity.onClick.AddListener(CallBack_Roll_Dexterity);

            t_Intelligence = GameObject.Find("t_Intelligence").GetComponent<Text>();
            b_Roll_Intelligence = GameObject.Find("b_Roll_Intelligence").GetComponent<Button>();
            b_Roll_Intelligence.onClick.AddListener(CallBack_Roll_Intelligence);

            t_Charisma = GameObject.Find("t_Charisma").GetComponent<Text>();
            b_Roll_Charisma = GameObject.Find("b_Roll_Charisma").GetComponent<Button>();
            b_Roll_Charisma.onClick.AddListener(CallBack_Roll_Charisma);

            t_Constitution = GameObject.Find("t_Constitution").GetComponent<Text>();
            b_Roll_Constitution = GameObject.Find("b_Roll_Constitution").GetComponent<Button>();
            b_Roll_Constitution.onClick.AddListener(CallBack_Roll_Constitution);

                        t_Constitution = GameObject.Find("t_Constitution").GetComponent<Text>();
            b_Roll_Constitution = GameObject.Find("b_Roll_Constitution").GetComponent<Button>();
            b_Roll_Constitution.onClick.AddListener(CallBack_Roll_Constitution);

            //Fetch the Dropdown GameObject
            dropdownRace = GameObject.Find("Dropdown_Race").GetComponent<Dropdown>();
            //Add listener for when the value of the Dropdown changes, to take action
            dropdownRace.onValueChanged.AddListener(DropdownRaceValueChanged);

            dropdownRace = GameObject.Find("Dropdown_Class").GetComponent<Dropdown>();
            //Add listener for when the value of the Dropdown changes, to take action
            dropdownRace.onValueChanged.AddListener(DropdownClassValueChanged);
        }



        //private void CallBack_EditEnd()
        //{
        //    Debug.Log("CallBack_EditEnd was called");
        //}

        //Ouput the new value of the Dropdown into Text
        void DropdownRaceValueChanged(int index)
        {
            race_Description.text = "Race: " + raceListdesc[index];
            if (index > 0)
            {
                pm.charRace = raceListdesc[index];
            }

        }

        void DropdownClassValueChanged(int index)
        {
            class_Description.text = "Class: " + classListdesc[index];
            if (index > 0)
            {
                pm.charClass = classListdesc[index];
            }
        }


        public void CallBack_Roll_Wisdom()
        {

            int wisdomChanged = DiceRollAlgo();
            t_Wisdom.text = wisdomChanged.ToString();
            pm.ability_Wisdom = wisdomChanged;

        }

        public void CallBack_Roll_Strength()
        {
            int strengthChanged = DiceRollAlgo();
            t_Strength.text = strengthChanged.ToString();
            pm.ability_Strength = strengthChanged;


        }
        public void CallBack_Roll_Dexterity()
        {
            int dexterityChanged = DiceRollAlgo();
            t_Dexterity.text = dexterityChanged.ToString();
            pm.ability_Dexterity = dexterityChanged;


        }
        public void CallBack_Roll_Intelligence()
        {
            int intelligenceChanged = DiceRollAlgo();
            t_Intelligence.text = intelligenceChanged.ToString();
            pm.ability_Intelligence = intelligenceChanged;


        }
        public void CallBack_Roll_Charisma()
        {
            int charismaChanged = DiceRollAlgo();
            t_Charisma.text = charismaChanged.ToString();
            pm.ability_Charisma = charismaChanged;

        }
        public void CallBack_Roll_Constitution()
        {
            int constitutionChanged = DiceRollAlgo();
            t_Constitution.text = constitutionChanged.ToString();
            pm.ability_Constitution = constitutionChanged;

        }

        /// Prof. Price "RollProfPriceCrazzy2020Algorythm ref
        private int DiceRollAlgo()
        {

            int outVal;
            List<int> d8List = new List<int>();
            List<int> d3List = new List<int>();

            d8List.Add(UnityEngine.Random.Range(1, 9));
            d8List.Add(UnityEngine.Random.Range(1, 9));
            d8List.Add(UnityEngine.Random.Range(1, 9));

            d3List.Add(UnityEngine.Random.Range(1, 4));
            d3List.Add(UnityEngine.Random.Range(1, 4));
            d3List.Add(UnityEngine.Random.Range(1, 4));
            d8List.Sort();
            d3List.Sort();
            d3List.RemoveAt(0);
            d8List.RemoveAt(0);

            return outVal = d3List.Sum() + d8List.Sum() + 2;
        }

        public class Race
        {
            public string Name = "";
            public string rDescription = "";
            public int HitPoints = 0;
            public float runningSpeed = 0;
            public float walkingSpeed = 0;
            public float jumpingHeightSpeed = 0;
            public string languages = "Common";
            public bool nightVision = false;

        }



        //quit button
        public void quitButton()
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
            Application.Quit();

        }

    }

}
