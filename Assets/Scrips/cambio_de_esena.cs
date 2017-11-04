using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cambio_de_esena : MonoBehaviour {


	public void cambiarEsena(int esena){
		SceneManager.LoadScene (esena);
		Vidas.vidas = 3;
		Puntos.puntos = 0;
	}


}
