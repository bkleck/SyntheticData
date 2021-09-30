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
    public string myPath;

    public void SetPath()
    {
        // save output folder path to play preferences
        // all scenes will use the same path
        string template = @"C:\Users\Boon Kong\Desktop\synthetic_data\{0}";
        string message = string.Format(template, myPath);

        PlayerPrefs.SetString("path", message);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveMenuItems()
    {
        List<int> SceneList = new List<int>();

        if (toggle1.GetComponent<Toggle>().isOn = true)
        {
            SceneList.Add(1);
        }

        else if (GameObject.Find("toggle2").GetComponent<Toggle>().isOn = true)
        {
            SceneList.Add(2);
        }

        else if (GameObject.Find("toggle3").GetComponent<Toggle>().isOn = true)
        {
            SceneList.Add(3);
        }


        else if (GameObject.Find("toggle4").GetComponent<Toggle>().isOn = true)
        {
            SceneList.Add(4);
        }


        else if (GameObject.Find("toggle5").GetComponent<Toggle>().isOn = true)
        {
            SceneList.Add(5);
        }


        else if (GameObject.Find("toggle6").GetComponent<Toggle>().isOn = true)
        {
            SceneList.Add(6);
        }


        else if (GameObject.Find("toggle7").GetComponent<Toggle>().isOn = true)
        {
            SceneList.Add(7);
        }

        int[] SceneArr = SceneList.ToArray();
        string Scenes = string.Join("", SceneArr);
        PlayerPrefs.SetString("Scenes", Scenes);
        PlayerPrefs.SetInt("Count", 0);


        /*
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
                SceneManager.LoadSceneAsync(nextIndex);
                Debug.Log($"Scene to load is {nextIndex}");
                // nextIndex = SceneManager.sceneCountInBuildSettings;
            }
        }


        if (nextIndex > SceneManager.sceneCountInBuildSettings)
        {
            // load menu
            SceneManager.LoadSceneAsync(0);
        }
        */
    }

    public void LoadGame()
    {
        string Scenes = PlayerPrefs.GetString("Scenes");
        int Count = PlayerPrefs.GetInt("Count");
        int RunScene = (int)Char.GetNumericValue(Scenes[Count]);
        SceneManager.LoadScene(RunScene);
        PlayerPrefs.SetInt("Count", Count++);
    }
}
