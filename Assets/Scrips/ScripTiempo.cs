using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScripTiempo : MonoBehaviour {
	public teclado t1;
	public GameObject canon;

	public Button empesar;
	public Button siguiente;
	public Button salir;

	public Text contadorTiempo;
	public Text acaboTiempo;
	public float tiempo = 120f;




	void Start () {
		contadorTiempo.text = "Tiempo : " + tiempo;
		acaboTiempo.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		tiempo-=Time.deltaTime;
		contadorTiempo.text = "Tiempo : " + tiempo.ToString("f0");
		if(tiempo<=0)
		{
			contadorTiempo.text = "0";
			acaboTiempo.enabled = true;
			t1.parar ();
			Destroy (canon.gameObject);
			siguiente.gameObject.SetActive (true);
			salir.gameObject.SetActive (true);
		}

	}
}
