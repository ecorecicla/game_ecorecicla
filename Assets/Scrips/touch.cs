using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class touch : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {
	public bool pulsando;


	public void OnPointerDown(PointerEventData eventData){
		pulsando = true;

	}


	public void OnPointerUp(PointerEventData eventData){
		pulsando = false;
	}


}
