using UnityEngine;

public class Cylinder : MonoBehaviour
{
    [SerializeField] 
    MeshFilter meshFilter;

    [SerializeField]
    MeshRenderer meshRenderer;

    [SerializeField]
    CapsuleCollider capsuleCollider;

    // 코드 기반으로 작업.
    // 나의 게임오브젝트에서 MeshFilter,MeshRenderer,CapsuleCollider 초기화.

    private void Start()
    {
        // 컴포넌트가 없으면 컴포넌트를 추가해

        if (!gameObject.TryGetComponent<CapsuleCollider>(out var collider))
        {
            // 2. 없을 때만 새로 추가
            collider = gameObject.AddComponent<CapsuleCollider>();
        }
        capsuleCollider = GetComponent<CapsuleCollider>();

        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();

    }
}
