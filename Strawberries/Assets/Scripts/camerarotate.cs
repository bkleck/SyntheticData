using UnityEngine;
using System.Collections;

public class camerarotate : MonoBehaviour
{

    public Transform target;//the target marker
    public float speedMod = 50.0f;//a speed modifier

    void Start()
    {//Set up things on the start method

    }

    void Update()
    {//move towards target with desired speed
        transform.position = Vector3.MoveTowards(transform.position, target.position, speedMod);
    }
}