using System;
using Events;
using UnityEngine;

public class RecoveryItem : MonoBehaviour
{
    [SerializeField] private EventIntValue _coinNumberEvent;
    private int _countCoin = 0;

    private void Awake()
    {
        _coinNumberEvent.InvokeEvents(_countCoin);
    }

    public void AddingCoin(int coin)
    {
        _countCoin += coin;
        _coinNumberEvent.InvokeEvents(_countCoin);
    }
}
