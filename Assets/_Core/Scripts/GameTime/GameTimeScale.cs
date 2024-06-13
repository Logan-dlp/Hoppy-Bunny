using UnityEngine;

namespace GameTime
{
    public class GameTimeScale : MonoBehaviour
    {
        private static GameTimeScale _instance;
        public static GameTimeScale Instance => _instance;

        private void Awake()
        {
            if (_instance !=null && _instance != this)
            {
                Destroy(_instance);
                return;
            }
            else
            {
                _instance = this;
            }
            
            DontDestroyOnLoad(this.gameObject);
        }

        public void SetTimeScale(float timeScale)
        {
            Time.timeScale = timeScale;
        }
    }
}