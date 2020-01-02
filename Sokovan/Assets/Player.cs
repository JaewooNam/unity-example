using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 10f;
    public Rigidbody playerRigidbody;

    // Start is called before the first frame update
    // 게임이 처음 시작되었을 때 한번 실행
    void Start() {

    }

    // Update is called once per frame
    // 화면이 한번 깜빡일때 한번 실행
    // 1초에 대략 60번, 단 사양에 따라 다르다.
    void Update() {
        // 여기에 유저입력을 넣어야한다.
        // W를 누를때 동작
        if (Input.GetKey(KeyCode.W)) {
            playerRigidbody.AddForce(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.A)) {
            playerRigidbody.AddForce(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S)) {
            playerRigidbody.AddForce(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.D)) {
            playerRigidbody.AddForce(speed, 0, 0);
        }
    }
}
