using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atropella : MonoBehaviour {
    // new IguanaCharacter iguanaCharacter;
    public static int puntuacion = 20;
    public Text adv,adv2,adv3,adv4;
    public Text points;
    public Text PuntajeN;
    public Text Tiempo;
    public Text Total;
    public Text gameover;
    public Manager estado;
    public GameObject UIGameOver;
    public GameObject UIGamePlay;
    public GameObject UIGameWin;
   // public GameObject para;
    private float tiempo2 = -3f;
    // Use this for initialization
    private void Awake()
    {
        //puntuacion = 20;
        actualizarPts();
        gameover.gameObject.SetActive(false);
        UIGameOver.SetActive(false);
       // UIGamePlay.SetActive(false);
        UIGameWin.SetActive(false);
        adv.gameObject.SetActive(false);
        adv.gameObject.SetActive(false);
        adv2.gameObject.SetActive(false);
        adv3.gameObject.SetActive(false);
        adv4.gameObject.SetActive(false);
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
    void Start () {
        //iguanaCharacter = GetComponent<IguanaCharacter>();
        /*adv.gameObject.SetActive(false);
        adv2.gameObject.SetActive(false);
        adv3.gameObject.SetActive(false);
        adv4.gameObject.SetActive(false);
        UIGameOver.SetActive(false);*/
    }
	
	// Update is called once per frame
	void Update () {
        tiempo2 = tiempo2 + Time.deltaTime;
        //iguanaCharacter.Death();
    }
    private void OnTriggerEnter(Collider igu)
    {
        if (igu.gameObject.tag == "Iguana")
        {
            Debug.Log("Atropellaste");
            igu.gameObject.SetActive(false);
            adv.gameObject.SetActive(true);
            puntuacion = puntuacion - 5;
            actualizarPts();
            VerificaPuntaje(puntuacion, gameover);
        
    }
        if (igu.gameObject.tag == "Ciervo")
        {
            Debug.Log("AtropellasteCiervo");
            igu.gameObject.SetActive(false);
            adv2.gameObject.SetActive(true);
            puntuacion = puntuacion - 10;
            actualizarPts();
            VerificaPuntaje(puntuacion, gameover);

        }
        if (igu.gameObject.tag == "Pecari")
        {
            Debug.Log("AtropellastePecari");
            igu.gameObject.SetActive(false);
            adv3.gameObject.SetActive(true);
            puntuacion = puntuacion - 15;
            actualizarPts();
            VerificaPuntaje(puntuacion, gameover);
        }

        if (igu.gameObject.tag == "Oso")
        {
            Debug.Log("AtropellasteOso");
            igu.gameObject.SetActive(false);
            adv4.gameObject.SetActive(true);
            puntuacion = puntuacion - 20;
            actualizarPts();
            VerificaPuntaje(puntuacion,gameover);
            
        }

        if (igu.gameObject.tag == "Finish")
        {
            Debug.Log("Ganaste");
            estado.m_estado = "GANASTE";
            UIGamePlay.SetActive(false);
            UIGameWin.SetActive(true);
            actualizarPtsN();
            Time.timeScale = 0;
           // Time.timeScale = (float)1.0 - Time.timeScale;
            //Time.fixedDeltaTime = (float)0.02 * Time.timeScale;
            // para.SetActive(true);

            estado.m_estado = "";
        }

    }
    void actualizarPts()
    {
        points.text = "Puntuación : " + puntuacion.ToString();

        //pts.gameObject.SetActive(true);
        //Debug.Log(puntuacion);
    }
    void actualizarPtsN()
    {
        PuntajeN.text = "Puntaje en este nivel: " + puntuacion.ToString();
        int t = (int)tiempo2;
        Tiempo.text = "Tiempo :" + t.ToString()+" segundos";
        if (tiempo2>100)
        {
            puntuacion = puntuacion + 50;
        }
        else
        {
            puntuacion = puntuacion + 100;
        }
        Total.text = "Puntaje total : " + puntuacion.ToString()+" pts.";

		WWW coneccion = new WWW ("http://game07environment.000webhostapp.com/game07/score.php?user=" + Gestor_BD.singleton.nombreUsuario + "&nScore=" + puntuacion);

        //pts.gameObject.SetActive(true);
        //Debug.Log(puntuacion);
    }
    void GameOver(Text g)
    {
        g.gameObject.SetActive(true);
        estado.m_estado = "GAMEOVER";
        Time.timeScale = 0;
       // Time.timeScale = (float)1.0 - Time.timeScale;
      //  Time.fixedDeltaTime = (float)0.02 * Time.timeScale;
    }
    void PasaNivel(GameObject g)
    {

    }
    void VerificaPuntaje(int p, Text g)
    {
        if (p <= 0)
        {
            GameOver(g);
        }
    }
}
