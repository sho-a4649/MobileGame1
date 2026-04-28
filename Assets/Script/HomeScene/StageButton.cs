using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageButton : MonoBehaviour
{
    public int stageIndex;
    public Button button;

    private void Start()
    {
        int unlockedStage = PlayerPrefs.GetInt("UnlockedStage", 1);
        button.interactable = stageIndex <= unlockedStage;
    }

    public void LoadStage()
    {
        SceneManager.LoadScene(stageIndex);
    }
}
