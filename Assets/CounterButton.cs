using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]

public class CounterButton : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(OnButtonClicked);
    }

    public void OnButtonClicked()
    {
       if(_counter.IsCunterActive == true)
        {
            _counter.StopCountdown();
        }
        else
        {
            _counter.Start—ountdown();
        }
    }
}