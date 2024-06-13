using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameScene
{
    public class LoadMultiScene : MonoBehaviour
    {
        [SerializeField] private string[] _sceneNameArray;
        [SerializeField] private bool _cursorIsVisible;

        private void Awake()
        {
            foreach (string itemName in _sceneNameArray)
            {
                SceneLoader.Instance.LoadScene(itemName, LoadSceneMode.Additive);
            }
            CursorGame.Instance.SetCursor(_cursorIsVisible);
        }
    }
}
