using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 10f;
    private Rigidbody playerRigidbody;
    // Start is called before the first frame update
    // 게임이 처음 시작되었을 때 한번 실행
    void Start() {
        // < type >
        // Generic 기법
        // Player 에 있는 component를 다 뒤져서 rigidbody를 가져옴.
        // 툴에서 드래그 & 드롭 할 필요가 없다.
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    // 화면이 한번 깜빡일때 한번 실행
    // 1초에 대략 60번, 단 사양에 따라 다르다.
    void Update() {
        // -1 ~ +1
        // Horizontal: 키보드 수평방향에 대응되는 키가 지정이 되있음
        // <- -> , A ~ D
        float inputX = Input.GetAxis("Horizontal");

        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y;
        // .AddForce = 힘 그자체
        // velocity = vector 3. x.y.z를 지정

        // 이 방법은 관성을 거치지않는다.
        Vector3 velocity = new Vector3(inputX, 0, inputZ);

        // = inputX * speed , 0 * speed, inputZ * speed
        velocity = velocity * speed;
        velocity.y = fallSpeed;
        playerRigidbody.velocity = velocity;
    }
}
