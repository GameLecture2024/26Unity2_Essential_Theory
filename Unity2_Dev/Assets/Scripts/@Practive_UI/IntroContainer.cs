using UnityEngine;
using UnityEngine.SceneManagement;

namespace DevTest
{
    public class IntroContainer : MonoBehaviour
    {
        
        public void StartButton()
        {
            SceneManager.LoadScene(1);
        }

        public void QuitButton()
        {
            Debug.Log("종료하겠습니다.");
            // 게임을 종료시키는 기능을 실행하라.
        }
    }
}
