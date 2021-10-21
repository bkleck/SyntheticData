using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Perception.GroundTruth;

public class Instantiation : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {   
        // Instantiate the object we loaded in the main menu
        GameObject myPrefab = GameObject.Find("LoadedObject");
        Instantiate(myPrefab, transform.position, myPrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
