using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloClass : MonoBehaviour
{
    void Start() {
        Animal jack = new Animal();
    }
}

public class Animal {
    string name;
    string sound;
    float weight;

}
