using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject scripts;

    private bool _outOfTime;
    private bool _collectedAllItems;

    #region Start
    private void Start()
    {
        scripts.GetComponent<Results>().Hide();
        scripts.GetComponent<Timer>().ResetTimer();
        scripts.GetComponent<Items>().ResetItems();
    }
    #endregion

    #region Update
    private void Update()
    {
        CheckLevelStatus();
    }
    #endregion

    #region Check Game Status
    private void CheckLevelStatus()
    {
        _collectedAllItems = scripts.GetComponent<Items>().CompareItems();
        _outOfTime = scripts.GetComponent<Timer>().CompareTime();

        if (_collectedAllItems == true)
        {
            Win();
        }

        if (_outOfTime == true)
        {
            Fail();
        }
    }
    #endregion

    #region Win
    private void Win()
    {
        scripts.GetComponent<Results>().Win();
        scripts.GetComponent<Results>().Show();
        scripts.GetComponent<Timer>().enabled   = false;
        StartCoroutine(scripts.GetComponent<Level>().NextLevel());
    }
    #endregion

    #region Fail
    public void Fail()
    {
        scripts.GetComponent<Results>().Fail();
        scripts.GetComponent<Results>().Show();
        scripts.GetComponent<Player>().enabled  = false;
        scripts.GetComponent<Timer>().enabled           = false;
        scripts.GetComponent<Items>().enabled           = false;
        StartCoroutine(scripts.GetComponent<Level>().Restart());
    }
    #endregion
}
