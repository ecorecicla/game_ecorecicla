using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teclado : MonoBehaviour {

	Transform _transform;
	public float speed=4;
	private float xAxis,zAxis;

	public touch btnIzquierda,btnDerecha;

	void Start () {
		//Debug.Log ("teclado");
		_transform = GetComponent<Transform> ();
	}
	
	void Update () {
		/*
		xAxis = Input.GetAxis ("Horizontal");
		zAxis = Input.GetAxis ("Vertical");
		Vector3 m=new Vector3(xAxis,0,zAxis);	
		_transform.TransformVector (m * speed * Time.deltaTime);
	

	//	if (Input.GetKey (KeyCode.W)) {
	//		_transform.Translate (new Vector3(0,0,-speed)*Time.deltaTime);
	//	}
	//	if (Input.GetKey (KeyCode.S)) {
	//		_transform.Translate (new Vector3(0,0,speed)*Time.deltaTime);
	//	}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			_transform.Translate (new Vector3(-speed,0,0)*Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			_transform.Translate (new Vector3(speed,0,0)*Time.deltaTime);
		}
	*/

		float direccion;
		if (btnIzquierda.pulsando) {
			direccion = -1;
		} else {
			if (btnDerecha.pulsando) {
				direccion = 1;
			} else {
				direccion = Input.GetAxisRaw ("Horizontal");
			}
		}	
		float pos_x = transform.position.x + (direccion * speed * Time.deltaTime);
		transform.position = new Vector3(Mathf.Clamp( pos_x,-8,8), transform.position.y, transform.position.z);


	}

	public void parar(){
		speed = 0;

	}

}





