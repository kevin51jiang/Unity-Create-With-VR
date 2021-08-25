using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour
{

    public float degreesPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.Rotate(0, 0, degreesPerSecond * Time.deltaTime);
        transform.Rotate(Vector3.up, degreesPerSecond * Time.deltaTime, Space.World);

    }
}
