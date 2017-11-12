using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripTachos : MonoBehaviour {

	public string color_tacho;
	public Puntos puntos;

	public AudioSource choquetacho;
	public AudioSource error;

	void OnTriggerEnter(Collider Obj){
		Destroy (Obj.gameObject);
		//choquetacho.Play ();
		if (Obj.gameObject.CompareTag (color_tacho)) {
			puntos.GanarPuntos ();
			choquetacho.Play ();
		} else {
			puntos.PerderPuntos();
			error.Play ();
		}
	}
}
