using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRanObj : MonoBehaviour {

	public GameObject[] obj;


	// Use this for initialization
	void Start () {
		Generar ();
	}

	// Update is called once per frame
	void Generar () {
		for (int i = 0; i < obj.Length; i++) {
			Instantiate(obj[Random.Range(0,obj.Length)],new Vector3(-i*2,3,0),transform.rotation);
		}

		//Instantiate(obj[Random.Range(0,obj.Length)],transform.position,transform.rotation);
	}
}
