using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WalletCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _numberView;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.ChangingNumber += DisplayCountdown;
    }

    private void OnDisable()
    {
        _counter.ChangingNumber -= DisplayCountdown;
    }

    public void DisplayCountdown()
    {
        int number = _counter.Number;
        _numberView.text = number.ToString("");
    }
}
