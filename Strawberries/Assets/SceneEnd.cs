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

        // go back to main menu
        SceneManager.LoadScene(0);
    }

    public bool OnSceneEnd()
    {
        return false;
    }
}
