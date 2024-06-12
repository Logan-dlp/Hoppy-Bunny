using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameScene
{
    public class SceneLoader : MonoBehaviour
    {
        private static SceneLoader _instance;
        public static SceneLoader Instance => _instance;

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(_instance.gameObject);
                return;
            }
            else
            {
                _instance = this;
            }
            DontDestroyOnLoad(this.gameObject);
        }

        public void LoadScene(string name, LoadSceneMode mode)
        {
            SceneManager.LoadScene(name, mode);
        }

        public void LoadScene(int index, LoadSceneMode mode)
        {
            SceneManager.LoadScene(index, mode);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}