using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour
{
    // Assign the "Game" scene in the Unity Editor
    public string gameSceneName = "Game";

    // Method to be called when the button is clicked
    public void OnTryAgainButtonClick()
    {
        // Load the "Game" scene
        SceneManager.LoadScene(gameSceneName);
    }
}



