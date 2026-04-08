using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DevTest
{
    public class IntroContainer : MonoBehaviour
    {
        
        public void StartButton()
        {
            SceneManager.LoadScene("@Dev3DAni");
        }

        public void QuitButton()
        {
            Debug.Log("종료하겠습니다.");

            Application.Quit();

#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#endif
        }

        public void ShowPopupUI()
        {
            Instantiate(Resources.Load<GameObject>("Prefabs/UI/PopupUI"));
        }
    }
}
