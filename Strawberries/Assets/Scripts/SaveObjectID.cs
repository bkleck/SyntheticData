using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveObjectID : MonoBehaviour
{
    public GameObject NameInput;

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
        // save user text input as object name in player preferences
        PlayerPrefs.SetString("object", NameInput.GetComponent<TMP_InputField>().text);
    }
}

