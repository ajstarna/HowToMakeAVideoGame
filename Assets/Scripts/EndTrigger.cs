using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager game_manager;
    private void OnTriggerEnter(Collider other)
    {
        game_manager.CompleteLevel();
    }
}
