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
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ScenarioEnd()
    {
        // Do your stuff here like load scene
        GetComponent<CustomScenario>().enabled = false;
        Debug.Log("End of scene");
        SceneManager.UnloadSceneAsync(1);
        SceneManager.LoadScene(2);
    }
}
