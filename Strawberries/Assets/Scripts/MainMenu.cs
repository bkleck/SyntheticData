using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject toggle1;
    public GameObject toggle2;
    public GameObject toggle3;
    public GameObject toggle4;
    public GameObject toggle5;
    public GameObject toggle6;
    public GameObject toggle7;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {   
        if (toggle1.GetComponent<Toggle>().isOn = true)
        {
            PlayerPrefs.SetInt("toggle1", 1);
        }
        else if (GameObject.Find("toggle1").GetComponent<Toggle>().isOn = false)
        {
            PlayerPrefs.SetInt("toggle1", 0);
        }

        else if (GameObject.Find("toggle2").GetComponent<Toggle>().isOn = true)
        {
            PlayerPrefs.SetInt("toggle2", 1);
        }
        else if (GameObject.Find("toggle2").GetComponent<Toggle>().isOn = false)
        {
            PlayerPrefs.SetInt("toggle2", 0);
        }

        else if (GameObject.Find("toggle3").GetComponent<Toggle>().isOn = true)
        {
            PlayerPrefs.SetInt("toggle3", 1);
        }
        else if (GameObject.Find("toggle3").GetComponent<Toggle>().isOn = false)
        {
            PlayerPrefs.SetInt("toggle3", 0);
        }

        else if (GameObject.Find("toggle4").GetComponent<Toggle>().isOn = true)
        {
            PlayerPrefs.SetInt("toggle4", 1);
        }
        else if (GameObject.Find("toggle4").GetComponent<Toggle>().isOn = false)
        {
            PlayerPrefs.SetInt("toggle4", 0);
        }

        else if (GameObject.Find("toggle5").GetComponent<Toggle>().isOn = true)
        {
            PlayerPrefs.SetInt("toggle5", 1);
        }
        else if (GameObject.Find("toggle5").GetComponent<Toggle>().isOn = false)
        {
            PlayerPrefs.SetInt("toggle5", 0);
        }

        else if (GameObject.Find("toggle6").GetComponent<Toggle>().isOn = true)
        {
            PlayerPrefs.SetInt("toggle6", 1);
        }
        else if (GameObject.Find("toggle6").GetComponent<Toggle>().isOn = false)
        {
            PlayerPrefs.SetInt("toggle6", 0);
        }

        else if (GameObject.Find("toggle7").GetComponent<Toggle>().isOn = true)
        {
            PlayerPrefs.SetInt("toggle7", 1);
        }
        else if (GameObject.Find("toggle7").GetComponent<Toggle>().isOn = false)
        {
            PlayerPrefs.SetInt("toggle7", 0);
        }

        // get index of current scene
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        int nextIndex = currentIndex + 1;
        Debug.Log($"Next index is {nextIndex}");
        Debug.Log($"Number of scenes is {SceneManager.sceneCountInBuildSettings}");


        // if next index is still within the build, and the toggle is on, then we load it
        // else we move on the to next index to try loading it
        // if it is out of range of the build, we load back the main menu
        if (nextIndex < SceneManager.sceneCountInBuildSettings)
        {
            string toggle = $"toggle{nextIndex}";
            Debug.Log($"Next index is {nextIndex}");
            if (PlayerPrefs.GetInt(toggle) == 1)
            {
                SceneManager.LoadScene(nextIndex);
                Debug.Log($"Scene to load is {nextIndex}");
                // nextIndex = SceneManager.sceneCountInBuildSettings;
            }
        }


        if (nextIndex > SceneManager.sceneCountInBuildSettings)
        {
            // load menu
            SceneManager.LoadScene(0);
        }

    }
}
