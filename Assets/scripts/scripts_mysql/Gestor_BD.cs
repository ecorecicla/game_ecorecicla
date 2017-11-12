using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gestor_BD : MonoBehaviour {
	public InputField txt_usuario;
	public InputField txt_contrasena;
	public string nombreUsuario;
	public int scoreUsuario;
	public int idUsuario;
	public bool sesionIniciada = false;
	public GameObject cuadro;
	public Text texo_cuadro;
	// un objeto unico para qu no xistan mas Gestores_BD
	// que solo aya uno en todo el juego.

	public static Gestor_BD singleton;


	//	Respuestas WEB
	// 	400 - no se puede establecer conexion
	//  401 - no encontro datos. no existe usuario
	//  402 - el usuario ya existe
	//
	//	200 - Datos entontrados. el usuario existe
	//	201 - usuario registrado  / no se encuantran los datos del usuario 
	//
	//	202 - score actualizado
	//	
	void Awake()
	{
		if (singleton == null) 
		{
			singleton = this;
		}
		else
		{
			Destroy (gameObject);
		}

	}

	public void Start(){
		DontDestroyOnLoad (this.gameObject);
		cuadro.SetActive (false);
	}


	public void iniciaSesion(){
		StartCoroutine (login ());
	}

	public void RegistrarUsuario()
	{
		StartCoroutine (registrar());
	}

	public void Actualizar_Score(int nScore){
		StartCoroutine (ActualizarScore (nScore));
	}


	IEnumerator login(){
		//WWW coneccion = new WWW ("http://localhost:8181/test_juego/login.php?user="+txt_usuario.text+"&pass="+txt_contracena.text);
	WWW coneccion = new WWW ("http://game07environment.000webhostapp.com/game07/login.php?user=" + txt_usuario.text + "&pass=" + txt_contrasena.text);
	//	WWW coneccion = new WWW ("http://game07environment.000webhostapp.com/game07/login.php?user=1&pass=1");

		cuadro.SetActive (true);

		yield return(coneccion);	
		if (coneccion.text == "200") {
			print ("el usuario existe...");
			StartCoroutine (datos());

		} else if (coneccion.text == "401") {
			print ("Usuario o contraceña incorrectos...");
			texo_cuadro.text="Usuario o contraseña incorrectos....!";
		} else {
			print ("Error en la conexion con  la BASE DE DATOS...");
			texo_cuadro.text = "Error en la conexion con  la BASE DE DATOS...!";
		}

	
	}

	IEnumerator datos(){

		//WWW coneccion = new WWW ("http://localhost:8181/test_juego/datos.php?user="+txt_usuario.text+"&pass="+txt_contracena.text);
		WWW coneccion = new WWW ("http://game07environment.000webhostapp.com/game07/datos.php?user=" + txt_usuario.text + "&pass=" + txt_contrasena.text);

		cuadro.SetActive (true);
		texo_cuadro.text ="iniciando sesion.....!";

		yield return(coneccion);	
		if (coneccion.text == "401") {
			print ("Usuario incorecto");

		} else {
				string[] ndatos = coneccion.text.Split ('|');
			print (coneccion.text);
			print (""+ndatos[0]);
			if (ndatos.Length != 3) {
				print ("Error en la conexion");	
				texo_cuadro.text ="Error con la conxion...!";
				}else
				{
				
				nombreUsuario=ndatos[0];
				scoreUsuario = int.Parse (ndatos [1]);
				idUsuario = int.Parse (ndatos [2]);
				sesionIniciada = true;
				SceneManager.LoadScene ("Inicio");

			}
		}			
	}


	IEnumerator registrar(){

		//WWW coneccion = new WWW ("http://localhost:8181/test_juego/registro.php?user=" + txt_usuario.text + "&pass=" + txt_contracena.text);
		WWW coneccion = new WWW ("http://game07environment.000webhostapp.com/game07/registro.php?user=" + txt_usuario.text + "&pass=" + txt_contrasena.text);
		cuadro.SetActive (true);

		yield return(coneccion);	

		if (coneccion.text == "402") {
			Debug.LogError ("El Usuario ya existe...!");
			texo_cuadro.text = "El usuario ya existe ...! ";
		} else if (coneccion.text == "201") { 
			nombreUsuario = txt_usuario.text;
			scoreUsuario = 0;
			sesionIniciada = true; 
			texo_cuadro.text = "El usuario a sido creado correctamente...!";
		} else {
			print (coneccion.text);
			print ("Error en la conexion con  la BASE DE DATOS...!");
			texo_cuadro.text ="ERROR EN LA RED .... ";
			
		}
	}
	IEnumerator ActualizarScore(int nScore){

		//WWW coneccion = new WWW ("http://localhost:8181/test_juego/score.php?user="+txt_usuario.text+"&nScore="+nScore.ToString());
		WWW coneccion = new WWW ("http://game07environment.000webhostapp.com/game07/score.php?user=" + txt_usuario.text + "&nScore=" + nScore);


			yield return(coneccion);	

			if (coneccion.text == "401") {
				Debug.LogError ("El Usuario NO existente...!");
			} else if (coneccion.text == "202") { 
				print ("Datos PUUNTAJE actualizados correctamente.");
				scoreUsuario = nScore;
				
			} else {
				print (coneccion.text);
				print ("Error en la conexion con  la BASE DE DATOS...");

			}

							
	}

	public void CerrarVentana(){
		cuadro.SetActive (false);
	}

}


