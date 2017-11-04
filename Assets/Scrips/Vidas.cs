using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Vidas : MonoBehaviour {
	public Button empesar;
	public Button siguiente;
	public Button salir;

	public teclado t1;
	//que solo exista una sola vida es decir gloval
	public static int vidas = 3;
	//variable texo para que se actualice
	public Text textoVidas;

	public ScripTiempo scripTiempo;

	//public Transform contenedorBloques; //  cañones

	public GameObject contenedorBloques;
	//public GameObject canon;
	public GameObject game_over;
	// Use this for initialization


	void Start () {
		ActualizarMarcadorVidas();
	}
	
	// Update is called once per frame   
	void ActualizarMarcadorVidas() {
		textoVidas.text = "Vidas : " + Vidas.vidas;
	}

	public void PerderVida()
	{
		Vidas.vidas--;
		ActualizarMarcadorVidas ();

		if (Vidas.vidas <= 0) {
			contenedorBloques.gameObject.SetActive (false);
			game_over.SetActive (true);
			t1.parar ();

			empesar.gameObject.SetActive (true);
			salir.gameObject.SetActive (true);
			scripTiempo.gameObject.SetActive (false);
			//vidas = 3;
		} 
	}
}
