using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

public GameObject PanelPause;

private int collectedCoins, victoryCondition = 3;

    public void PauseControl()
    {
        if (Time.timeScale == 1){
            PanelPause.SetActive (true);
            Time.timeScale = 0;
        } else {
            Time.timeScale = 1;
            PanelPause.SetActive (false);
        }
    }

    public void Restart ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MenuUtama()
    {
        Application.LoadLevel(0);
    }




//whjfdj


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    private static GameManager instance;

    public static GameManager MyInstance
    {
        get
        {
            if (instance == null)
                instance = new GameManager();
            
            return instance;
        }
    }

    private void Start()
    {
        UIManager.MyInstance.UpdateCoinsUI(collectedCoins, victoryCondition);
    }

    public void AddCoins(int _coins)
    {
        collectedCoins += _coins;
        UIManager.MyInstance.UpdateCoinsUI(collectedCoins, victoryCondition);
    }

    public void Finish()
    {
        if (collectedCoins >= victoryCondition)
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            UIManager.MyInstance.ShowVictoryCondition(collectedCoins, victoryCondition);
            
        }
    }

    public void Finish1()
    {
        if (collectedCoins >= victoryCondition)
        {
            SceneManager.LoadScene("SLSTG1");
        }
        else
        {
            UIManager.MyInstance.ShowVictoryCondition(collectedCoins, victoryCondition);
            
        }
    }


}