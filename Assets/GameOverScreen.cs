using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    public Text scoretext;
    public void Setup(float score)
    {
        gameObject.SetActive(true);
        scoretext.text = score.ToString();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
