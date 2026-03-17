using UnityEngine;

public class MazeTrigger : MonoBehaviour
{
    public bool IsGoalTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        MazeBall ball = other.gameObject.GetComponentInParent<MazeBall>();
        if (ball)
        {
            if (IsGoalTrigger)
            {
                return;
            }
            else
            {
                ball.ResetBall();
            }
                
        }
    }
}
