using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(new Vector3(0, -90, 0));
    }

    // Update is called once per frame
    void Update()
    {
        // y -90도인데. 0도 될때까지 계속 바뀌게 해줘.   +

        // 1 x 90 = 0   360 -> 360 
        // transform.rotation.y? 0 작을 때만 해라.
        if(transform.localRotation.y <= 0)
            transform.Rotate(new Vector3(0, 1, 0));
    }
}
