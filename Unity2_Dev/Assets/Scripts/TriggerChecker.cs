using UnityEngine;

namespace DevTest
{
    public class TriggerChecker : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Interact"))
            {
                Debug.Log($"충돌한 객체의 이름 : {other.name}");

                // other -> Door이름. Box Collider
                // 부모 parent 갔더니 클래스 이름이 Door 녀석이 있더라.
                // 너의 부모 오브젝트에 Component 이름이 Door 녀석에 값을 저장하겠다.

                Door parentDoor = other.GetComponentInParent<Door>();
                parentDoor.OpenDoor();

                //if (TryGetComponent<Door>(out Door otherDoor))
                //{
                //    otherDoor.OpenDoor();
                //}
            }
        }
    }
}
