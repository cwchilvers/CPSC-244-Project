using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    #region Start Game
    public void StartGame()
    {
        SceneManager.LoadScene("Level 01");
    }
    #endregion

    #region Quit Game
    public void QuitGame()
    {
        Application.Quit();
    }
    #endregion

    #region MainMenu
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    #endregion

    #region Restart
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    #endregion
}
