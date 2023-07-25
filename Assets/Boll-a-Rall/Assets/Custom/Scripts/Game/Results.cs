using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    public GameObject   results;
    public Text         resultsText;

    public void Show()
    {
        results.SetActive(true);
    }

    public void Hide()
    {
        results.SetActive(false);
    }

    public void Win()
    {
        resultsText.text = "WIN";
    }

    public void Fail()
    {
        resultsText.text = "FAIL";
    }
}
