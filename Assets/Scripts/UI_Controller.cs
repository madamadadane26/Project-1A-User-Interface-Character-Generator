using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Random = System.Random;
using System.Linq;


namespace CS583
{
    public class UI_Controller : MonoBehaviour
    {
        public Text CharNameout;
        public InputField CharNameIn;

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
        }

        private void CallBack_EditEnd()
        {
            Debug.Log("CallBack_EditEnd was called");
        }


        private void CallBack_Roll_Wisdom()
        {

            int wisdom = DiceRollAlgo();
            t_Wisdom.text = wisdom.ToString();


        }

        public void CallBack_Roll_Strength()
        {
            int strength = DiceRollAlgo();
            t_Strength.text = strength.ToString();

        }
        public void CallBack_Roll_Dexterity()
        {
            int dexterity = DiceRollAlgo();
            t_Dexterity.text = dexterity.ToString();

        }
        public void CallBack_Roll_Intelligence()
        {
            int intelligence = DiceRollAlgo();
            t_Intelligence.text = intelligence.ToString();

        }
        public void CallBack_Roll_Charisma()
        {
            int charisma = DiceRollAlgo();
            t_Charisma.text = charisma.ToString();

        }
        public void CallBack_Roll_Constitution()
        {
            int constitution = DiceRollAlgo();
            t_Constitution.text = constitution.ToString();

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

        //quit button
        public void quitButton()
        {
            Debug.Log("EXIT");
            Application.Quit();
        }

    }

}
