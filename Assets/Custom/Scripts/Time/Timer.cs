using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text resultText;
    public GameObject scripts;

    private int _currentLevel;
    private float _time;
    private float _time_lv01 = Constants.TIME_LV01;
    private float _time_lv02 = Constants.TIME_LV02;
    private float _time_lv03 = Constants.TIME_LV03;

    private void Update()
    {
        UpdateTime();
        UpdateTimer();
    }

    private void UpdateTime()
    {
        _time -= Time.deltaTime;
    }

    private void UpdateTimer()
    {
        if (_time > 0)
        {
            timerText.text = (_time).ToString("0");
        }   
    }

    public void ResetTimer()
    {
        GetCurrentLevel();

        if (_currentLevel == 1)
        {
            _time = _time_lv01;
        }

        if (_currentLevel == 2)
        {
            _time = _time_lv01;
        }

        if (_currentLevel == 3)
        {
            _time = _time_lv01;
        }
    }

    public bool CompareTime()
    {
        if (_time <= 0)
        {
            return true;
        }

        else
            return false;
    }

    private void GetCurrentLevel()
    {
        _currentLevel = scripts.GetComponent<Level>().currentLevel;
    }
}
