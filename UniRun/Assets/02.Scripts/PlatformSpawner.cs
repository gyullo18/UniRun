using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 이전 총알 생성기에서 사용했던 방식의 매번 필요시 마다 사용했던'Instantiate'(생성)방식이 아닌, 오브젝트 풀링 방식을 사용.
// 오브젝트 풀링(Object Pooling) - 게임 초기에 필요한 만큼 오브젝트를 미리 만들어 '풀(Pool):웅덩이'에 쌓아두는 방식.
// 왜 해당 방식이 필요한가?
// Instantiate() 메서드처럼 오브젝트를 실시간으로 생성하거나 Destroy() 메서드처럼 오브젝트를 실시간으로 파괴하는 처리는
// 성능을 많이 요구 또한 메모리를 정리하는 GC(Garbage Colletion)을 유발하기 쉬움.
// 게임 도중 오브젝트를 너무 자주 생성하거나 파괴하면 게임 끊김(프리즈) 현상이 발생.
public class PlatformSpawner : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
