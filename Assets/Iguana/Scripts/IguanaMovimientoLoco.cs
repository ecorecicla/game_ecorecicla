using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IguanaMovimientoLoco : MonoBehaviour {

    IguanaCharacter iguanaCharacter;

    void Start()
    {
        iguanaCharacter = GetComponent<IguanaCharacter>();
    }

    void Update()
    {
        iguanaCharacter.Move(9f, 9f);
    }
}
