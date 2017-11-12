using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public GameObject UINuevoJuego;
    public GameObject UIGamePlay;

    public Manager Estado;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void btnNuevoJuego()
    {
        //UINuevoJuego.SetActive(false);
       // UIGamePlay.SetActive(true);
        Estado.m_estado = "PLAY";
        SceneManager.LoadScene("Carrera_Inicial");
    }

    public void btnGameOver()
    {
        SceneManager.LoadScene("Carrera_Inicial");
    }
    public void btnWin()
    {
        SceneManager.LoadScene("Recicla1");
		Puntos.puntos = Atropella.puntuacion;
    }
    public void btnWin2()
    {
        SceneManager.LoadScene("Nivel2");
    }
    public void btnWin3()
    {
        SceneManager.LoadScene("Recicla2");
		Puntos.puntos = Atropella.puntuacion;
    }
	public void btnWin4()
	{
		SceneManager.LoadScene("Nivel3");
	}
	public void btnWin5()
	{
		SceneManager.LoadScene("Nivel4");
	}
    public void btnVolver()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void btnCreditos()
    {
        SceneManager.LoadScene("Créditos");
    }
    public void btnSalir()
    {
        Application.Quit();
        Debug.Log("Salir");
    }
    public void btnAyuda()
    {
        SceneManager.LoadScene("Ayuda");
    }
    public void btnAyuda2()
    {
        SceneManager.LoadScene("Ayuda2");
    }
    public void btnAyuda3()
    {
        SceneManager.LoadScene("Ayuda3");
    }
}

