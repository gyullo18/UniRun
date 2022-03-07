using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임 오브젝트를 지속적으로 왼쪽으로 움직이는 스크립트.
public class ScrollingObject : MonoBehaviour
{
    // 이동 속도
    public float speed = 10f;

    void Update()
    {
        // 초당 스피드의 속도로 왼쪽으로 평행이동 구현. "transform : 자기 자신의 Transform컴포넌트"
        // Translate - 평행이동 메서드(이동할 거리)
        // Time.deltatime - 초당!!
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
