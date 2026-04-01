using UnityEngine;

namespace DevTest
{
    public class WarriorPlayerAC_Blend : MonoBehaviour
    {
        private Animator animator;
        private int SpeedHash;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            // int SpeedHash 입력을 할때마다 값이 바뀌도록 만드는 코드를 짜줘.
            // Rigidbody velocity  

            //animator.SetInteger("Speed", SpeedHash);

            // bool isPlayerHit if()

            if(Input.GetKeyDown(KeyCode.F))
                animator.Play("WarriorPlayer_HitReaction");
        }
    }
}
