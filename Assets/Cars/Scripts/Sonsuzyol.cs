using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonsuzyol : MonoBehaviour {

	public int YolSayisi = 10;

	public GameObject Yol;


	private Transform[] yollar;
	private Transform Kamera;

	private int FirstPrefab;
	private float YolUzunluk;
	// Use this for initialization
	void Start () {

		Kamera = Camera.main.transform;
		yollar = new Transform[YolSayisi];
		FirstPrefab = 0;

		YolUzunluk = Yol.GetComponent<MeshFilter>().sharedMesh.bounds.size.z;

		for(int i = 0; 1<YolSayisi; i++){
             
			Vector3 pozisyonu = new Vector3(0,0, i * YolUzunluk);
			yollar[i] = (Instantiate(Yol,pozisyonu,Quaternion.identity) as GameObject).transform;

		}
			
	}
	
	// Update is called once per frame
	void Update () {
		float kameraZ = Kamera.position.z;
		float BastakiyolZ = yollar [FirstPrefab].position.z;



		if (kameraZ >= BastakiyolZ + YolUzunluk) {

			yollar[FirstPrefab].position += new Vector3 (0, 0, YolUzunluk * YolSayisi);

			FirstPrefab++;
			if (FirstPrefab >= YolSayisi)
				FirstPrefab = 0;
		
		}
	}
}
