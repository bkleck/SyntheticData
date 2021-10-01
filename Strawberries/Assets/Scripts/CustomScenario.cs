using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Perception.Randomization.Scenarios;

public class CustomScenario : FixedLengthScenario
{
    protected override void OnIdle()
    {   
        Debug.Log($"The no. of randomizers is {randomizers.Count}");
        Restart();
        GetComponent<SceneEnd>().ScenarioEnd();
    }

    protected override void OnIterationEnd()
    {
        Debug.Log($"current iter is {currentIteration},{GetInstanceID()}");
    }

    protected override void OnStart()
    {
        currentIteration = 0;
        Debug.Log("onawake");
    }

    protected override void OnComplete()
    {
        
    }
}

