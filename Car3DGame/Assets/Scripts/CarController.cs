using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed= 45.0f;
    private float horizontalInput;
    private float fowardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");
        //transform.Translate(0,0,1);
        //transform.Translate(Vector3.forward * Time.deltaTime*20);
        transform.Translate(Vector3.forward * Time.deltaTime*speed* fowardInput);
        //transform.Translate(Vector3.right * Time.deltaTime*turnSpeed*horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime*turnSpeed*horizontalInput);
    }
}
