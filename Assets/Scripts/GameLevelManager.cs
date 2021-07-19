using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLevelManager : MonoBehaviour
{
    private static GameLevelManager _instance = null;
    public static GameLevelManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameLevelManager>();
            }
            return _instance;
        }
    }

    [SerializeField] public int m_PlayerMaxHealth = 5;
    [SerializeField] public int m_PlayerMaxScore = 99;
    [SerializeField] private Image[] hearts;
    [SerializeField] private Sprite m_fullheart;
    [SerializeField] private Sprite m_emptyheart;

    public GameOverScreen gameOverScreen;

    public int m_PlayerCurrentHealth;
    public float m_PlayerCurrentScore;
    public Text m_ScoreText;

    private void Start() {
        m_PlayerCurrentHealth = m_PlayerMaxHealth;
        m_PlayerCurrentScore = 0;
        m_ScoreText.text = $"{m_PlayerCurrentScore}";
    }

    public void GameOver(){
        gameOverScreen.Setup(m_PlayerCurrentScore);
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        CheckHealth();
    }

    void CheckHealth()
    {
        if(m_PlayerCurrentHealth > m_PlayerMaxHealth)
        {
            m_PlayerCurrentHealth = m_PlayerMaxHealth;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < m_PlayerCurrentHealth)
            {
                hearts[i].sprite = m_fullheart;
            } else {
                hearts[i].sprite = m_emptyheart;
            }

            if (i < m_PlayerMaxHealth)
            {
                hearts[i].enabled = true;
            } else {
                hearts[i].enabled = false;
            }
        }

        if(m_PlayerCurrentHealth < 1)
        {
            GameOver();
            Time.timeScale = 0;
        }
    }

    public void HealHealth(int value)
    {
        m_PlayerCurrentHealth += value;
    }

    public void SetHealth(int value)
    {
        m_PlayerCurrentHealth = value;
    }
    public void ReduceHealth(int value)
    {
        m_PlayerCurrentHealth -= value;
    }

    public void AddScore(int value)
    {
        m_PlayerCurrentScore += value;
        m_ScoreText.text = $"{m_PlayerCurrentScore}";
    }
}
