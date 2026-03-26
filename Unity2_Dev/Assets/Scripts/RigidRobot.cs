using UnityEngine;

public class RigidRobot : Robot
{
    Rigidbody rigid;
    bool CanMove = true;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>(); 
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        if (CanMove)
            RobotMove();
        else
            rigid.linearVelocity = Vector3.zero;
    }

    // On Collision OnTrigger

    // Enter Exit Stay

    // 모든 대상으로 충돌을 하더라. 특별 대상만 충돌하고 싶다. How?
    // 이름 / Tag / Script - 

    // Shape Casting


    private void OnTriggerEnter(Collider other)
    {
  
        CanMove = false;
    }

}