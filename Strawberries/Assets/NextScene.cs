using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{ 
    void Start()
    {
        void LoadNextScene()
        {
            SceneManager.LoadScene(2);
            Debug.Log("Loaded scene");
        }
    }

    }