using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private Coroutine _coroutine;

    private int _increasingNumber = 1;

    public bool IsCunterActive { get; private set; }
    public int Number { get; private set; }
    public event Action ChangingNumber;

    private IEnumerator Countdown()
    {
        var delay = new WaitForSeconds(0.5f);

        while (Number >= 0)
        {
            AddNumber(_increasingNumber);

            yield return delay;
        }
    }

    private void AddNumber(int number)
    {
        Number += number;

        if (ChangingNumber != null)
        {
            ChangingNumber.Invoke();
        }
    }

    public void Start—ountdown()
    {
        IsCunterActive = true;

        _coroutine = StartCoroutine(Countdown());
    }

    public void StopCountdown()
    {
        IsCunterActive = false;

        StopCoroutine(_coroutine);
    }
}