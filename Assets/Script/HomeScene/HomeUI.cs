using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeUI : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject selectPanel;
    public GameObject resetPanel;

    private void Start()
    {
        ShowMain();
        resetPanel.SetActive(false);
    }

    public void ShowMain()
    {
        mainPanel.SetActive(true);
        selectPanel.SetActive(false);
        resetPanel.SetActive(false);
    }

    public void ShowSelect()
    {
        mainPanel.SetActive(false);
        selectPanel.SetActive(true);
        resetPanel.SetActive(false);
    }

    // リセット確認を表示
    public void ShowResetConfirm()
    {
        resetPanel.SetActive(true);
    }

    // はい：セーブデータ削除
    public void ResetStageData()
    {
        // ステージ開放データを初期化
        PlayerPrefs.SetInt("UnlockedStage", 1);

        // 念のため保存
        PlayerPrefs.Save();

        // ホームに戻す
        ShowMain();
    }

    // いいえ：閉じる
    public void Cancelreset()
    {
        resetPanel.SetActive(false);
    }

    // Start
    public void StartGame()
    {
        SceneManager.LoadScene(1); // ステージ１
    }
}
