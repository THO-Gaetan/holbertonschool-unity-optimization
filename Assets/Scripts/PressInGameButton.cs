using UnityEngine;

public class PressInGameButton : MonoBehaviour
{
    [SerializeField] private GameObject MoveWall;

    public void Interact()
    {
        Debug.Log("Button Pressed");
        MoveWall.SetActive(false);
    }
}
