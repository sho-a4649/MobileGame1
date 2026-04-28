using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearUI : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false); // 最初は非表示
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void NextStage() // 次のステージ
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current + 1);
    }
    
    public void Retry() // リトライ
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Home() // ホーム
    {
        SceneManager.LoadScene("Home");
    }
}
