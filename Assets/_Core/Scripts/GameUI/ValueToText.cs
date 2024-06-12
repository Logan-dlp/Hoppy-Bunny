using TMPro;
using UnityEngine;

namespace GameUI
{
    public class ValueToText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;

        public void SetText(float value)
        {
            _text.text = value.ToString();
        }

        public void SetText(int value)
        {
            _text.text = value.ToString();
        }
    }
}