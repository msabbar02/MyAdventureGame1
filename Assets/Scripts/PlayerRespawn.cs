using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    private float checkpointX, checkpointY;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("CheckpointX") != 0)
        {
            transform.position = new Vector2(PlayerPrefs.GetFloat("CheckpointX", checkpointX), PlayerPrefs.GetFloat("CheckpointY", checkpointY));
        }

    }

    public void ReachedCheckpoint(float x, float y)
    {
        checkpointX = x;
        checkpointY = y;
        // Save the checkpoint position to PlayerPrefs
        PlayerPrefs.SetFloat("CheckpointX", checkpointX);
        PlayerPrefs.SetFloat("CheckpointY", checkpointY);
    }

    public void PlayerDamage()
    {
        animator.Play("HitAnim");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
