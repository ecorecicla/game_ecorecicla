using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoFinPartida : MonoBehaviour {

	//es el audio de la scena
	public AudioSource audioSorce;
	//los audios que deseamos que suene despues del audio de la scna
	public AudioClip completado;
	public AudioClip gameOver;

	//metodo llamado cuando perderemos todas la vidas
	public void GameOver()
	{
		ReproduceSonido(gameOver);
	}

	//metodo llamado cuando complete un nivel
	public void NivelCompletado()
	{
		ReproduceSonido(completado);
	}

	void ReproduceSonido(AudioClip sonido)
	{
		audioSorce.clip = sonido;
		audioSorce.loop = false;
		audioSorce.Play ();
	}
}



	/*
	//todo este codigo simplificado en un solo metodo "ReproduceSonido"
	//el sonido de la scena gameover
	public void GameOver()
	{
		//el audio "completado" ahora sera el audio de la scena principal 
		audioSorce.clip = gameOver;
		//la sonido de scena no sonara mas 
		audioSorce.loop = false;
		audioSorce.Play ();
	}

	//el sonido de la scena finalizar el juego
	public void NivelCompletado()
	{
		//el audio "completado" ahora sera el audio de la scena principal 
		audioSorce.clip = completado;
		//la sonido de scena no sonara mas 
		audioSorce.loop = false;
		audioSorce.Play ();
	}
	*/
