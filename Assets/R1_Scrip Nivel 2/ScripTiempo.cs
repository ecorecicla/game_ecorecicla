using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScripTiempo : MonoBehaviour {

	public Text contadorTiempo;
	public Text acaboTiempo;
	public float tiempo = 13f;


	public GameObject nivelCompletado;
	public GameObject gameOver;
	public Transform puntosAparacion;
	public GameObject pared2;

	public Button btnSalir;
	public Button btnSigNivel;

	// Use this for initialization
	void Start () {
		//contadorTiempo.text = "tiempo : " + tiempo;
		//contadorTiempo.enabled=false;
		acaboTiempo.enabled = false;
		//pared2.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		tiempo-=Time.deltaTime;

		if (tiempo <= 10) {
			contadorTiempo.text = "tiempo : " + tiempo.ToString("f0");
		}
		//
		if(tiempo <= 0)
		{
			contadorTiempo.text = "0";
			acaboTiempo.enabled = true;
			nivelCompletado.SetActive (true);

			puntosAparacion.gameObject.SetActive (false);
			pared2.gameObject.SetActive (true);

			btnSigNivel.gameObject.SetActive (true);
			btnSalir.gameObject.SetActive (true);
		}

	}
}
