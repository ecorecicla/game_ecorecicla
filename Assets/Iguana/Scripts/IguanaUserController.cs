using UnityEngine;
using System.Collections;

public class IguanaUserController : MonoBehaviour {
	IguanaCharacter iguanaCharacter;
	
	void Start () {
		iguanaCharacter = GetComponent < IguanaCharacter> ();
	}
	
	void Update () {
        iguanaCharacter.Move(1f, 0f);
        if (Input.GetButtonDown ("Fire1")) {
			iguanaCharacter.Attack();
		}
		
		if (Input.GetKeyDown (KeyCode.H)) {
			iguanaCharacter.Hit();
		}
		
		if (Input.GetKeyDown (KeyCode.E)) {
			iguanaCharacter.Eat();
		}

		if (Input.GetKeyDown (KeyCode.K)) {
			iguanaCharacter.Death();
		}
		
		if (Input.GetKeyDown (KeyCode.R)) {
			iguanaCharacter.Rebirth();
		}		

	}
}
