using Unity.Simulation;
using UnityEngine;

public class DataOutput : MonoBehaviour
{
    public string myPath;
    string template = @"C:\Users\Boon Kong\Desktop\synthetic_data\{0}";

    void Start()
    {
        string message = string.Format(template, myPath);
        Configuration.localPersistentDataPath = message;
    }
}
