using UnityEngine;

namespace DevTest
{
    public class WarriorPlayerAC : MonoBehaviour
    {
        private Animator animator;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            animator = GetComponent<Animator>();
        }

        // Loop Animation 정의 :  1D 2D Blending Locomotion
        // LoopX Animation 정의

        private void Update()
        {
            if (Input.GetKey(KeyCode.D))
                animator.Play("WarriorPlayer_Run");
            else
                animator.Play("WarriorPlayer_Idle");
        }

    }
}
