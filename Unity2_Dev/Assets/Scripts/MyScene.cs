using UnityEngine;

public class MyScene : MonoBehaviour
{
    [SerializeField]
    GameObject RobotPrefab;

    [SerializeField]
    GameObject DoorPrefab;

    [SerializeField]
    Camera CameraPrefab;

    [SerializeField]
    GameObject Floor;

    [SerializeField]
    Light Sun;

    // Loading - memory Load 끝날 때 까지 기다리겠다. 기다리는 로딩바, 로딩씬 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        Instantiate(RobotPrefab, new Vector3(0, 1, 0), Quaternion.identity);
        GameObject door = Instantiate(DoorPrefab, new Vector3(25, 0, 30), Quaternion.identity);
        door.name = "Door";

        Instantiate(Sun);
        Instantiate(Floor);
        Instantiate(CameraPrefab, new Vector3(0, 1, 0), Quaternion.identity);
    }

    // 속도(방향) 거리

    // Update is called once per frame
    void Update()
    {
        
    }
}
