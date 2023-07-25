using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public int currentLevel;
    public Text levelText;

    void Update()
    {
        UpdateLevelText();
    }

    #region Level Text
    private void UpdateLevelText()
    {
        levelText.text = "Level " + currentLevel.ToString();
    }
    #endregion

    #region Restart Level
    public IEnumerator Restart()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Level 0" + currentLevel.ToString()); ;
    }
    #endregion

    #region Next Level
    public IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(3);

        if (currentLevel != 3)
        {
            currentLevel += 1;
            SceneManager.LoadScene("Level 0" + currentLevel.ToString());
        }

        else
        {
            SceneManager.LoadScene("Menu");
        }
    }
    #endregion
}