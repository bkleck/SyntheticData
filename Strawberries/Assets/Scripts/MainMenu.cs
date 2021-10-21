using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    /*
    public GameObject toggle1;
    public GameObject toggle2;
    public GameObject toggle3;
    public GameObject toggle4;
    public GameObject toggle5;
    public GameObject toggle6;
    public GameObject toggle7;
    */
    // public string myPath;

    //public void SetPath()
    //{
    //    // save output folder path to play preferences
    //    // all scenes will use the same path
    //    string template = @"C:\Users\Boon Kong\Desktop\synthetic_data\{0}";
    //    string message = string.Format(template, myPath);

    //    PlayerPrefs.SetString("path", message);
    //}

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
        /*
        // Create a new list to store the toggle values
        List<int> SceneList = new List<int>();

        // Store the toggle number in the list of is was turned on by the user
        if (toggle1.GetComponent<Toggle>().isOn == true)
        {
            SceneList.Add(1);
        }

        if (toggle2.GetComponent<Toggle>().isOn == true)
        {
            SceneList.Add(2);
        }

        if (toggle3.GetComponent<Toggle>().isOn == true)
        {
            SceneList.Add(3);
        }


        if (toggle4.GetComponent<Toggle>().isOn == true)
        {
            SceneList.Add(4);
        }


        if (toggle5.GetComponent<Toggle>().isOn == true)
        {
            SceneList.Add(5);
        }


        if (toggle6.GetComponent<Toggle>().isOn == true)
        {
            SceneList.Add(6);
        }


        if (toggle7.GetComponent<Toggle>().isOn == true)
        {
            SceneList.Add(7);
        }

        // convert list to array to string, and store it in Player Preferences
        // Store a counter inside as well
        int[] SceneArr = SceneList.ToArray();
        string Scenes = string.Join("", SceneArr);
        Debug.Log($"Scenes Array is {Scenes}");
        PlayerPrefs.SetString("Scenes", Scenes);
        PlayerPrefs.SetInt("Count", 0);
        */


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
        /*
        string Scenes = PlayerPrefs.GetString("Scenes");
        int Count = PlayerPrefs.GetInt("Count");

        // Get the scene to run by indexing the characters in the string according to current count
        // then converting to int
        int RunScene = (int)Char.GetNumericValue(Scenes[Count]);
        SceneManager.LoadScene(RunScene);

        // After loading the scene, increase the count in PlayerPrefs
        PlayerPrefs.SetInt("Count", ++Count);
        */

        SceneManager.LoadScene(1);
    }
}
