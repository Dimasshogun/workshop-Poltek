using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtCoins, txtVictoryCondition;
    [SerializeField] GameObject victoryCondition;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate (this);
        }
    }
    private static UIManager instance;

    public static UIManager MyInstance
    {
        get
        {
            if (instance == null)
                instance = new UIManager();

            return instance;
        }
    }

    public void UpdateCoinsUI(int _coins, int _victoryCondition)
    {
        txtCoins.text = "Gulungan: " + _coins + " / " + _victoryCondition;
    }

    public void ShowVictoryCondition(int _coins, int _victoryCondition)
    {
        victoryCondition.SetActive(true);
        txtVictoryCondition.text = "Kamu Butuh " + (_victoryCondition - _coins) + "gulungan lagi untuk dapat membuka peti";
    }

    public void HideVictoryCondition()
    {
        victoryCondition.SetActive(false);
    }
}
