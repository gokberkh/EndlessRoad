using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class skor2 : MonoBehaviour { 

    public static int puan = 0;
    public Transform player;
    public Text count;

    // Use this for initialization
    void Start()
    {

        count.text = "Skor = " + puan.ToString();
    }
    // +player.position.z.ToString("0");
    // Update is called once per frame
    void Update()
    {


        count.text = "Skor = " + puan.ToString();


    }



}
