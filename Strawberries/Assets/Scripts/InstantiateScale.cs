using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScale : MonoBehaviour
{
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject Placeholder = Instantiate(myPrefab, transform.position, myPrefab.transform.rotation * Quaternion.Euler(90f, 90f, 90f));
        Placeholder.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
