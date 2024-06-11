using TMPro;
using UnityEngine;

namespace GameTime
{
    public class GameTimer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _timerText;
        [SerializeField] private float _timer;

        private void Update()
        {
            if (_timer < 0) _timer = 0; else _timer -= Time.deltaTime;

            float minutes = Mathf.FloorToInt(_timer / 60);
            float secondes = Mathf.FloorToInt(_timer % 60);
            float millisecondes = _timer % 1 * 1000;

            _timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, secondes, millisecondes);
        }
    }
}
