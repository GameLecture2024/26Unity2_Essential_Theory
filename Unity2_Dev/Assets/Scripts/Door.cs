using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private int doorRotateValue = -90;

    [SerializeField][Range(0,10)] 
    private int doorClosePower = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(new Vector3(0, doorRotateValue, 0));
    }

    // Update is called once per frame
    void Update()
    {
        // y -90도인데. 0도 될때까지 계속 바뀌게 해줘.   +

        // 1 x 90 = 0   360 -> 360 
        // transform.rotation.y? 0 작을 때만 해라.
        if(transform.localRotation.y <= doorRotateValue)
            transform.Rotate(new Vector3(0, doorClosePower, 0));
    }

    public void OpenDoor()
    {
        Debug.Log("Open Door");

        // 플래그 / Event 방식을 사용해서 문이 진짜 열리도록.

        if (transform.localRotation.y >= 0)
            transform.Rotate(new Vector3(0, -doorClosePower, 0));
    }

    public void CloseDoor()
    {
        Debug.Log("Close Door");

        // 플래그 / Event 방식을 사용해서 문이 진짜 열리도록.

        if (transform.localRotation.y <= 0)
            transform.Rotate(new Vector3(0, doorClosePower, 0));
    }
}
