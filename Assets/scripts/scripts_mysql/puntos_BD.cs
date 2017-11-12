using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puntos_bd : MonoBehaviour {

	int c=0;
	// Update is called once per frame
	void Update () {
		c++;
		GetComponent<Text> ().text = "Puntos: " + Gestor_BD.singleton.scoreUsuario;
		Gestor_BD.singleton.Actualizar_Score (c);
		Debug.Log (Gestor_BD.singleton.scoreUsuario+"");
	}
}
