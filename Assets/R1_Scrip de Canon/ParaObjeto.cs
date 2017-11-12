using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaObjeto : MonoBehaviour {

	public float Speed = 1;
    public float LifeTime;
	
	 private float _age;

    void Start () {
        transform.parent = null;
    }
	
    void Update () {
        _age += Time.deltaTime;
        this.transform.Translate(new Vector3(0, 0, Speed) * Time.deltaTime);

        if (_age > LifeTime) {
            Destroy(this.gameObject);
        }

        // transform.forward
        // transform.left 
        // this.transform.position = this.transform.position + new Vector3(0, 0, Speed) * Time.deltaTime;
	}
}
