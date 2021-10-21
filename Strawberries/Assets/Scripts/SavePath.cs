using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SavePath : MonoBehaviour
{
    public GameObject DataPath;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveID()
    {
        // save user text input as data output path in local drive
        string template = @"C:\Users\Boon Kong\Desktop\synthetic_data\{0}";
        string myPath = DataPath.GetComponent<TMP_InputField>().text;
        string message = string.Format(template, myPath);
        PlayerPrefs.SetString("path", message);

        // create directory if it does not exist
        if (Directory.Exists(message))
        {
            Debug.Log("Directory already exists");
        }
        else
        {
            Directory.CreateDirectory(message);
            Debug.Log("Directory was created.");
        }
    }

}
