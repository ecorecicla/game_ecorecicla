using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour {

	public float time = 0f;
	public GameObject[] obj;

	void Start () {
		time = Time.time;	
	
	}
	
	void Update () {
		if(Time.time-time > 2f){
			Instantiate(obj[Random.Range(0,obj.Length)],transform.position,Quaternion.identity);
			time = Time.time;
		}
	}
}