using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour {

	//public string escenaACargar;

	//public void cambioEsc(int escena)
	public void cambioEsc(int escena)
	{
		SceneManager.LoadScene (escena);
		Atropella.puntuacion = Puntos.puntos;
		//Puntos.puntos = 0;
		//Vidas.vidas++;
	}
}
