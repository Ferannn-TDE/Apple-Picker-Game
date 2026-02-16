using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    [Header("UI References")]
    public GameObject startScreen;
    public Button startButton;
    public Button restartButton;
    public Text roundText;
    
    [Header("Game Settings")]
    public int maxRounds = 4;
    private int currentRound = 1;
    
    [Header("Dynamic")]
    public bool gameStarted = false;
    public bool gameOver = false;
    
    private static GameManager _instance;
    public static GameManager Instance {
        get { return _instance; }
    }
    
    void Awake() {
        // Singleton pattern
        if (_instance != null && _instance != this) {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }
    
    void Start() {
        // Setup initial UI state
        if (startScreen != null) {
            startScreen.SetActive(true);
        }
        
        if (startButton != null) {
            startButton.onClick.AddListener(StartGame);
        }
        
        if (restartButton != null) {
            restartButton.gameObject.SetActive(false);
            restartButton.onClick.AddListener(RestartGame);
        }
        
        if (roundText != null) {
            roundText.gameObject.SetActive(false);
        }
        
        // Pause the game until start button is pressed
        Time.timeScale = 0f;
    }
    
    public void StartGame() {
        gameStarted = true;
        Time.timeScale = 1f;
        
        if (startScreen != null) {
            startScreen.SetActive(false);
        }
        
        if (roundText != null) {
            roundText.gameObject.SetActive(true);
            UpdateRoundText();
        }
    }
    
    public void NextRound() {
        currentRound++;
        
        if (currentRound > maxRounds) {
            EndGame();
        } else {
            UpdateRoundText();
        }
    }
    
    void UpdateRoundText() {
        if (roundText != null) {
            roundText.text = "Round " + currentRound;
        }
    }
    
    public void EndGame() {
        gameOver = true;
        
        if (roundText != null) {
            roundText.text = "Game Over";
        }
        
        if (restartButton != null) {
            restartButton.gameObject.SetActive(true);
        }
        
        // Stop the game
        Time.timeScale = 0f;
    }
    
    public void RestartGame() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public int GetCurrentRound() {
        return currentRound;
    }
}