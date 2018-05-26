using UnityEngine;
using System.Collections;

// Bu script kameranın arabayı yumuşak (smooth) bir şekilde takip etmesini sağlamakta
public class KameraScript : MonoBehaviour 
{
	public Transform araba;
	public float mesafe = 5f;
	public float yukseklik = 2f;
	
	private Transform tr;
	
	void Start()
	{
		tr = transform;
		tr.position = araba.position + new Vector3( 0, yukseklik, -mesafe );
	}
	
	void FixedUpdate()
	{
		// kamera mevcut konumundan hedef konuma doğru yumuşak şekilde hareket edecek
		Vector3 hedefKonum = araba.position + new Vector3( 0, yukseklik, -mesafe );
		//Vector3 hedefKonum = araba.position - araba.forward * mesafe + Vector3.up * yukseklik;
		tr.position = Vector3.Slerp( tr.position, hedefKonum, 0.5f );
		
		// kamerayı arabayla birlikte döndürmeye yarayan bir kod parçası
		/*Vector3 mevcutRotasyon = tr.eulerAngles;
		float hedefYEgim = Mathf.LerpAngle( tr.eulerAngles.y, araba.eulerAngles.y, 0.15f );
		mevcutRotasyon.y = hedefYEgim;
		tr.eulerAngles = mevcutRotasyon;*/
	}
}
