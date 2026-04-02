using UnityEngine;

namespace DevTest
{
    public class WarriorPlayerAC_Blend : MonoBehaviour
    {
        private Animator animator;
        private int SpeedHash;

        private float currentSpeed = 0f; // 실제 Animator에 전달할 부드러운 값
        public float acceleration = 5f;  // 속도 변화 가속
        public int targetSpeed = 0;

        private Rigidbody2D rigid2D;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            animator = GetComponent<Animator>();
            rigid2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            HandleInput();

            // 2. 현재 속도를 목표 속도로 부드럽게 보간 (Lerp 사용)
            currentSpeed = Mathf.Lerp(currentSpeed, targetSpeed, Time.deltaTime * acceleration);

            Debug.Log($"currentSpeed : {currentSpeed}");

            // 3. Animator의 Speed 파라미터 업데이트
            animator.SetFloat("Speed", currentSpeed);

            if(Input.GetKey(KeyCode.Space))
            {
                // 점프하는 애니메이션을 실행해야 한다.
                animator.Play("WarriorPlayer_Jump");
                rigid2D.AddForceY(currentSpeed * 1000);
            }
        }

        void HandleInput()
        {
            if (Input.GetKey(KeyCode.LeftShift))
                targetSpeed = 10; // Dash
            else if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
                targetSpeed = 5;  // Run
            else
                targetSpeed = 0;  // Idle
        }
    }
}
