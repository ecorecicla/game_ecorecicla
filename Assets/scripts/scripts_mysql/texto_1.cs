using UnityEngine;
using UnityEngine.UI;

public class texto_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		GetComponent<Text> ().text = "Hola,  " + Gestor_BD.singleton.nombreUsuario + "  ,Bienvenido.....! ";
	}
	public void ChangeScores(int nScore){
		Gestor_BD.singleton.Actualizar_Score (nScore);
	}	

}
