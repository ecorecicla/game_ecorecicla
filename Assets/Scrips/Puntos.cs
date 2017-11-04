using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {

	//text de puntos para mostara en pantalla 
	public static int puntos=0;
	//estara sera el texto
	public Text textoPuntos;
	//llamanos a vidas
	public Vidas vida;

	void Start () {
		ActualizarMarcadorPuntos ();
	}

	public void ActualizarMarcadorPuntos()
	{
		textoPuntos.text = "Puntos : "+ Puntos.puntos;
	}

	//cada ves que se llame este metodo aumentara un punti
	public void GanarPuntos()
	{
		//ganamos puntos
		Puntos.puntos++;
		//y despues tiene que actualizarce
		ActualizarMarcadorPuntos();
		if(Puntos.puntos<=0)
		{
			vida.PerderVida ();
		}
	}

	//cada que se llame disminuye
	public void PerderPuntos()
	{
		Puntos.puntos--;

		if(Puntos.puntos<=0)
		{
			vida.PerderVida ();
			puntos = 0;
			//aqui necesitamosmostrar mensaje que se perdio una vida

		}
		ActualizarMarcadorPuntos();
	}
}
