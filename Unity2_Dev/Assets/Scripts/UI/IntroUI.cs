using UnityEngine;

namespace DevTest
{
    public class IntroUI : MonoBehaviour
    {
        // Resources 폴더 안에 특정 경로

        // IntroScene 씬에 호출해야할 에셋들이 잠들어 있다

        private void Start()
        {
            Init();
        }

        private void Init()
        {
            // Resources / Prefabs / UI / 안에 있는 프리팹을 가져와야한다.
            GameObject canvas = Resources.Load<GameObject>("Prefabs/UI/Canvas");
            canvas.name = "IntroCanvas";
            GameObject canvasGo = Instantiate(canvas); // 메모리에 올라갔다.

            // Canvas의 자식으로 "SceneUI" - 고정형 UI, 약속된 용어 
            GameObject introSceneUI = Resources.Load<GameObject>("Prefabs/UI/IntroSceneUI");
            Instantiate(introSceneUI, canvasGo.transform);


        }
    }
}
