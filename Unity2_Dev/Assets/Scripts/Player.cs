using UnityEngine;

namespace DevTest
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        float moveSpeed = 10.0f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
        }

        // 200FPS 1/200  0..016 0.005 10 x 200 =  1000 ~ 2000
        // 

        // Update is called once per frame
        void Update()
        {
            // Horizontal (-1 1) => x
            // Vertical   (-1 1) => z

            // if(Input.GetAxis(W))

            float hoizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            Vector3 MoveInput = new Vector3(hoizontal, 0, vertical);

            // 속성 속도와 관련된 movespeed 만들어보세요. 사칙연산 이동

            transform.position += MoveInput * moveSpeed * Time.deltaTime;    //매우 빠르다. Frame - Time.deltatime
        } 
    }
}
