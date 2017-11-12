using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonDeObjetos : MonoBehaviour {

	public float time = 0f;
	public Transform [] prefab=new Transform[10];

	void Start () {
		time = Time.time;	
	}

	void Update () {

		if (Time.time - time > 2f) {
			int n = Random.Range (0, 9);
			Instantiate (prefab [n], this.transform.position, this.transform.rotation);
			time = Time.time;
		}
	}


	////////////////////////
	//velocidad en que saldran los objetos
	/*public float CooldownTime = 0.5f;
    public GameObject BulletPrototype;

    private float _timeSinceLastShot = 0;

    void Start () {
    }

    void Update () {
        _timeSinceLastShot += Time.deltaTime;

        if (_timeSinceLastShot > CooldownTime) {
            _timeSinceLastShot = 0;
            GameObject clon = Instantiate(BulletPrototype);
            clon.SetActive(true);
            clon.transform.position = BulletPrototype.transform.position;
            clon.transform.rotation = BulletPrototype.transform.rotation;
        }
    }
*/


	////////////////////////
}
