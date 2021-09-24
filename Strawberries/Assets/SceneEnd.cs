using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Perception.Randomization.Scenarios;


public class SceneEnd : MonoBehaviour
{ 
    public FixedLengthScenario currentScenario;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentScenario.isActiveAndEnabled == false)
        {
            SceneManager.LoadScene(0);
        }
    }
}
