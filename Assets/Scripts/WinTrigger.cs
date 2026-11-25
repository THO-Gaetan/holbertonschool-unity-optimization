using UnityEngine;
using System.Collections;
using TMPro;

public class WinTrigger : MonoBehaviour
{
    public MonoBehaviour timerScript;
    public TMP_Text timerText;
    public TMP_Text FinishTimeText;
    public GameObject winCanvas;
    public GameObject timerCanvas;
    public GameObject EventManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            FinishTimeText.text = timerText.text;
            timerScript.enabled = false;
            timerCanvas.SetActive(false);
            EventManager.SetActive(false);
            winCanvas.SetActive(true);
        }
    }
}
