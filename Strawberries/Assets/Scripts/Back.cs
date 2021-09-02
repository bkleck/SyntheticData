using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, transform.position, Quaternion.Euler(90f, 0f, 0f));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
