using UnityEngine;

namespace DevTest
{
    public class DevCol : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
           if(other.CompareTag("Interact"))
           {
                HandleCollision();
           }

        }

        private void HandleCollision()
        {
            Debug.Log("충돌한 객체만 있으면. 그 객체를 위로 올리고 싶다.");
        }

        private void OnTriggerStay(Collider other)
        {
           // Debug.Log("트리거 충돌 Stay"); 
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Interact"))
            {
               Debug.Log("트리거 충돌 Exit"); 
            }


        }
    }
}
