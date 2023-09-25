using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI textTimer;
    [SerializeField] public int second, minute;

    private void Start()
    {
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        int timer = 0;
        while (true)
        {
            timer++;
            second = timer % 60;
            minute = (timer / 60) % 60;
            textTimer.text = minute.ToString() + ":" + second.ToString();
            yield return new WaitForSeconds(1f);
        }
    }
}
