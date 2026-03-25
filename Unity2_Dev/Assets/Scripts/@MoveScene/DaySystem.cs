using UnityEngine;

namespace DevTest
{
    public class DaySystem : MonoBehaviour
    {
        [SerializeField]
        Light sunLight;

        [SerializeField]
        float currentTime = 6;
        [SerializeField]
        float timeSpeed = 0.1f;



        [SerializeField]
        float lightRisexValue;
        [SerializeField]
        float lightDawnxValue;

  

        private void Update()
        {
            // 1. 시간 흐름 계산
            currentTime += Time.deltaTime * timeSpeed;
            if (currentTime >= 24) currentTime = 0;

            // 2. X축 회전값 계산
            // 6시를 0도로 맞추기 위해 (currentTime - 6)을 사용합니다.
            // 1시간당 회전 각도 = (일몰각도 - 일출각도) / 12시간
            float degreesPerHour = (lightDawnxValue - lightRisexValue) / 12f;
            float currentXRotation = lightRisexValue + (currentTime - 6f) * degreesPerHour;

            // 3. 라이트에 회전 적용 (Y값은 해가 뜨는 방향에 맞춰 적절히 조절하세요, 예: -90)
            sunLight.transform.localRotation = Quaternion.Euler(currentXRotation, -90f, 0f);
        }
    }
}
