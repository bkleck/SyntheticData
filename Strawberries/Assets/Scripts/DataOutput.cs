using Unity.Simulation;
using UnityEngine;

public class DataOutput : MonoBehaviour
{
    void Start()
    {   
        // Get data output path from Player Preferences
        string message = PlayerPrefs.GetString("path");
        Configuration.localPersistentDataPath = message;
    }
}
