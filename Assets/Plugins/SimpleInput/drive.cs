using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drive : MonoBehaviour {

    private float inputHor;
    private float inputver;
    private string horizontalAxis = "Horizontal";
    private string verticalAxis = "Vertical";

	// Update is called once per frame
	void Update () {
        
        inputHor = SimpleInput.GetAxis(horizontalAxis);
        inputver = SimpleInput.GetAxis(verticalAxis);
        transform.Rotate(0, inputHor * 5f, 0f, Space.Self);
		
	}
}
