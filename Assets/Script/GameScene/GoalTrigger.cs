using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;

public class GoalTrigger : MonoBehaviour
{
    public ClearUI clearUI;

    public ParticleSystem goalEffect;
    public Stage stage;
    public Rigidbody ballRb;
    public float nextDelay = 1.0f;

    private bool cleared = false;

/*    private void Start()
    {
        int unlockedStage = PlayerPrefs.GetInt("UnlockedStage", 1);

        //Button.interactable = stageIndex <= unlockedStage;
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (cleared) return;

        if (other.CompareTag("Player"))
        {
            cleared = true;
            StartCoroutine(GoalSequence());
        }
    }

    IEnumerator GoalSequence()
    {
        // 操作停止
        stage.canControl = false;

        // ボール停止
        ballRb.velocity = Vector3.zero;
        ballRb.angularVelocity = Vector3.zero;
        ballRb.isKinematic = true;

        // エフェクト
        if (goalEffect != null)
            goalEffect.Play();

        // 少し待つ
        yield return new WaitForSeconds(0.5f);

        // UI表示
        clearUI.Show();

        int currentStage = SceneManager.GetActiveScene().buildIndex;
        int unlockedStage = PlayerPrefs.GetInt("UnlockedStage", 1);

        // クリアしたステージを保存
        if (currentStage + 1 > unlockedStage)
        {
            PlayerPrefs.SetInt("UnlockedStage", currentStage + 1);
        }
    }
}
