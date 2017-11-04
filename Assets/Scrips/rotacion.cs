using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour {

	//public bool pulsando;
	private float _age;
	//public float LifeTime=1f;
	//Time.deltaTime

	void Update () {
		transform.Rotate(new Vector3(90,90,90 ) * Time.deltaTime);	
	}
}
