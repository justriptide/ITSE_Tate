using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public MazeManager mazeManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mazeManager.EndGame();
        }
    }
}