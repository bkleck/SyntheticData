using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Perception.GroundTruth;

public class OnCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PerceptionCamera>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
