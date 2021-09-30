using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Perception.Randomization.Scenarios;

public class CustomScenario : FixedLengthScenario
{
    protected override void OnComplete()
    {
        GetComponent<SceneEnd>().ScenarioEnd();
    }
}