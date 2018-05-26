using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class skor : MonoBehaviour {
    public Transform player;
    public Text skortext;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        skortext.text = player.position.z.ToString("0");
	}
}
