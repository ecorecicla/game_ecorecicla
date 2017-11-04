using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRanObj : MonoBehaviour {

	public GameObject[] obj;

	public float tiempoMin = 1f;
	public float tiempoMax = 2f;
	// Use this for initialization
	void Start () {
		Generar ();
	}
	void Update()
	{
	}
	// Update is called once per frame
	void Generar () {
		//Instantiate(obj[Random.Range(0,obj.Length)],transform.position,transform.rotation);
		Instantiate(obj[Random.Range(0,obj.Length)],transform.position,Quaternion.identity);
		Invoke ("Generar",Random.Range(tiempoMin,tiempoMax));
	}
}
