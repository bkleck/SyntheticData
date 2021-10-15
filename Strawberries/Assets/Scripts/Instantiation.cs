using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instantiation : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameObject myPrefab = GameObject.Find("LoadedObject");
        Instantiate(myPrefab, transform.position, myPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
