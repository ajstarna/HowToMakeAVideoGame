using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool game_has_ended = false;
    public float restart_delay = 2f;
    public GameObject comple_level_UI;

    public void CompleteLevel ()
    {
        comple_level_UI.SetActive(true);
    }

    public void EndGame ()
    {
        if (game_has_ended == false)
        {
            Debug.Log("Game over!");
            game_has_ended = true;
            Invoke("Restart", restart_delay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
