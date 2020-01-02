using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");

        // 주석
        /* */

        // 소숫점 아래 7자리까지만 정확. 끝에 f를 붙인다.
        // 32비트
        float height = 0.1234567f;

        // float의 두배의 메모리를 사용, 64비트
        // 소숫점 아래 15자리 까지만 정확
        double pi = 3.14159265359;
        
        bool isBoy = true;
        bool isGirl = false;

        char grade = 'A';

        string movieTitle = "Matrix";

        // var는 할당하는 값을 기준으로 타입을 결정
        var myName = "JaewooNam";
        // = string myName = "...."
        
        int height_1 = 170;
        float heightDetail = 170.3f;
        
        // 자동 형변환 (잃어버리는 정보가 없으면)
        heightDetail = height_1;

        // 직접 명시해야 하는 경우 (잃어버리는 정보가 있으면)
        height_1 = (int)heightDetail;

        
    }
}
