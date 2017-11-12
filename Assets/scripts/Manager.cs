using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    public GameObject UIGamePlay;
    public GameObject UIGameOver;
    public GameObject UIGameWin;
    public string m_estado;
	// Use this for initialization
	void Start () {
        m_estado = "Bienvenido";
        UIGameWin.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if (m_estado == "GAMEOVER")
        {
            UIGamePlay.SetActive(false);
            UIGameOver.SetActive(true);

            m_estado = "";
        }
        if (m_estado == "GANASTE")
        {
            UIGamePlay.SetActive(false);
            UIGameWin.SetActive(true);

            m_estado = "";
        }
    }
}
