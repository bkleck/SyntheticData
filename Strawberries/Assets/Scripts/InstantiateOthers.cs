using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOthers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.FindWithTag("myPrefab");
        Instantiate(obj, transform.position, obj.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
