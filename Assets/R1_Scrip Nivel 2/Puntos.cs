using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {

	//public Atropella aa;
	public static int puntos;

	public Text textoPuntos;

	public Button salir;
	public Button empiezaPrincipio;

	public ScripTiempo scripTiempo;

	public GameObject ParedFinal;

	// Use this for initialization
	void Start () {
		ActualizarMarcadorPuntos ();
		if (Time.timeScale == 0)
		{
			Time.timeScale = 1;
		}
	}

	public void ActualizarMarcadorPuntos()
	{
		textoPuntos.text = "Puntos : "+ Puntos.puntos;
	}

	//cada ves que se llame este metodo aumentara un punti
	public void GanarPuntos()
	{
		Puntos.puntos++;
		ActualizarMarcadorPuntos();
	}

	//cada que se llame disminuye
	public void PerderPuntos()
	{
		//perdemos puntos
		Puntos.puntos--;
		if(Puntos.puntos<=0)
		{
			empiezaPrincipio.gameObject.SetActive (true);
			salir.gameObject.SetActive (true);
			scripTiempo.gameObject.SetActive (false);
			ParedFinal.gameObject.SetActive (true);
		}
		ActualizarMarcadorPuntos();
	}
}
