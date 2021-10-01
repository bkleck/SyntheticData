using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Perception.Randomization.Scenarios;

public class SceneEnd : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log($"The frame is {GetComponent<CustomScenario>()}");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ScenarioEnd()
    {
        // disable the Scenario once it ends, to prevent auto shutdown of application
        GetComponent<CustomScenario>().enabled = false;

        string Scenes = PlayerPrefs.GetString("Scenes");
        int Count = PlayerPrefs.GetInt("Count");

        // If count less than length of string, we continue indexing
        // else we just go back to main menu
        if (Count < Scenes.Length)
        {
            // Get the scene to run by indexing the characters in the string according to current count
            // then converting to int
            int RunScene = (int)Char.GetNumericValue(Scenes[Count]);
            SceneManager.LoadSceneAsync(RunScene);
            Debug.Log("Next scene loaded");
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());

            // After loading the scene, increase the count in PlayerPrefs
            PlayerPrefs.SetInt("Count", ++Count);
        }

        else
        {
            SceneManager.LoadScene(0);
        }
    }

    public bool OnSceneEnd()
    {
        return false;
    }
}
