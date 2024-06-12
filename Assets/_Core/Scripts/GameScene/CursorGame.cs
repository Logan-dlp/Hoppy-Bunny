using UnityEngine;

namespace GameScene
{
    public class CursorGame : MonoBehaviour
    {
        private static CursorGame _instance;
        public static CursorGame Instance => _instance;

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

        public void SetCursor(bool isVisible, CursorLockMode mode)
        {
            Cursor.visible = isVisible;
            Cursor.lockState = mode;
        }
    }
}