using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private Button exitButton;

    public void Exit()
    {
        exitButton.onClick.AddListener(() => { Application.Quit(); Debug.Log("Exited"); });
    }
}
