using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        float circle = 30f;
        float radius = getRadius(circle);
        Debug.Log("** radius = " + radius);
    }

    float getRadius(float size) {
        float pi = 3.14f;
        float tmp = size / pi;
        float radius = Mathf.Sqrt(tmp);

        return radius;
    }
}
