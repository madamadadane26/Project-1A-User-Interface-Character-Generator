using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace CS583
{
    public class menuScreenController : MonoBehaviour
    {

        public Button startButton;
        public Button ExitButton;


        private void moreUIReferences()
        {

            startButton = GameObject.Find("buildCharButton").GetComponent<Button>();
            startButton.onClick.AddListener(buildCharButton);

            ExitButton = GameObject.Find("quitButton").GetComponent<Button>();
            ExitButton.onClick.AddListener(quitButton);

        }




        //create character button
        public void buildCharButton()
        {
            SceneManager.LoadScene(1);
        }

        //quit button
        public void quitButton()
        {
            Debug.Log("QUIT");
            Application.Quit();
        }


    }
}
