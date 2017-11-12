using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IguanaMovimientoCircular : MonoBehaviour {

    IguanaCharacter iguanaCharacter;

    void Start()
    {
        iguanaCharacter = GetComponent<IguanaCharacter>();
    }

    void Update()
    {
        iguanaCharacter.Move(1f, 1f);
    }
}