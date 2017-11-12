
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ContadorScript : MonoBehaviour {
   // public GameObject para;
    public Text Contador;
    public Text fin;
    public Text temp;
    private float tiempo = 3f;
    private float tiempo2 = -3f;
    

	void Start () {
        Contador.text = " " + tiempo;
        fin.enabled = false;
        temp.enabled = false;
       // para.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        tiempo =tiempo-Time.deltaTime;
        Contador.text = " " + tiempo.ToString("f0");

        if(tiempo <= 0)
        {
            Contador.text = "0";
            Contador.enabled = false;
            fin.enabled = true;
            temp.enabled = true;
           // para.SetActive(false);
            
        }
        
        tiempo2 = tiempo2 + Time.deltaTime;
        temp.text = "Tiempo : " + tiempo2.ToString("f0")+" seg.";

    }
}
