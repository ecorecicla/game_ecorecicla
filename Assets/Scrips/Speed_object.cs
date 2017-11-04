using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_object : MonoBehaviour {

	public float speed=1;
	public float _life_time=10f;

	private float _age;
	void Start () {
		transform.parent = null;
	}
	
	void Update () {
		_age += Time.deltaTime;
		this.transform.Translate (new Vector3(0,0,speed)*Time.deltaTime);

		if(_age>_life_time){
			Destroy (this.gameObject);
		}
	}
}
