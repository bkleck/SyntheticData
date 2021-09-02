using UnityEngine;
using System.Collections;
public class camerazoom : MonoBehaviour
{

    public Transform target;//the target marker
    public float speedMod = 30.0f;//a speed modifier

    void Start()
    {//Set up things on the start method

    }

    void Update()
    {//move towards target with desired speed
        transform.position = Vector3.MoveTowards(transform.position, target.position, speedMod);
    }
}
