using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public MonoBehaviour timerScript;

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            timerScript.enabled = true;
            Debug.Log("Timer Started");
    }
}
