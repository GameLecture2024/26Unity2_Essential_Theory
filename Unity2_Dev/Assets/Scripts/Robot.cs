using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 10f;

    Vector3 direction;

    // 문 세트장에 있는 문중에서 어떤 문인지 알 수 있는 방법이 있어야 된다. Find
    // 이름 찾기
    // 태그로 찾기
    // 스크립트 이름으로 찾기

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 어디로 갈거다. X Y Z 어느 방향으로 갈것인가.
        // transform.rotation = Quaternion.Euler(0, 0, 0);

        GameObject cachedDoor = GameObject.Find("Door");

        direction = cachedDoor.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 방향   Scalar스칼라 Vector
        transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
    }
}
