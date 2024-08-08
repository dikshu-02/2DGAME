using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class RetryScene : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;

   
        // Retrieve the score from PlayerPrefs
        void Start()
        {
            string score = PlayerPrefs.GetString("score", "0");
            scoreDisplay.text = "FINAL SCORE: " + score;
        }


    

    // Add other methods and functionality as needed

    // Update is called once per frame
    void Update()
    {
        //
    }
}








