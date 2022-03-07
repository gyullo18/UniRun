using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 왼쪽 끝으로 이동한 배경을 오른쪽 끝으로 재배치 처리.
public class BackgroundLoop : MonoBehaviour
{
    // 배경의 가로 길이
    private float width;

    // Unity Event Method
    private void Awake()
    {
        // Awake -- Start() 메서드처럼 초기 1회 자동 실행되는 유니티 메서드.
        // 하지만, Start()메서드 보다 샐행 시점이 한 프레임 더 빠름.
        // # 참조 : Unity Method LifeCycle

        // 가로 길이 측정 -- 지역변수로 할당.
        // BoxCollider 2D 컴포넌트의 Size  필드의 X 값을 가로 길이로 사용.
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }

    void Update()
    {
        // 1. 현재 위치가 원점에서 왼쪽으로 width 이상 이동했을 때(if()), 2. 위치 재배치({}).
        if (transform.position.x <= -width)
        {
            Reposition();
        }
    }

    // 위치 재배치 메서드
    void Reposition()
    {
        // 현재 위치에서 오른쪽으로 (가로 길이 * 2)만큼 이동.
        Vector2 offset = new Vector2(width * 2f, 0);
        // 순간이동 -- 연산처리 시 offset은 2D, position은 3D이기 때문에 형변환 필요.
        transform.position = (Vector2)transform.position + offset;
        // width : 20.48 * 2 = 40.48
        // -20.48 + 40.48(offset) = 20.48
    }
}
