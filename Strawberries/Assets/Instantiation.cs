using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, new Vector3(133, 174, -211), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
