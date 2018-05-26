using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arab : MonoBehaviour
{

    public WheelCollider onsol, onsag, arkasol, arkasag;
    public float hiz, donmehiz;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        arkasol.motorTorque = hiz * Input.GetAxis("Vertical");
        arkasag.motorTorque = hiz * Input.GetAxis("Vertical");
        onsol.steerAngle = donmehiz * Input.GetAxis("Horizontal");
        onsag.steerAngle = donmehiz * Input.GetAxis("Horizontal");



    }
}
