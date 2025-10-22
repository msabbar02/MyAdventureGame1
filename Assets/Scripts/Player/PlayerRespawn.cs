using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    private float checkpointX, checkpointY;
    public Animator animator;
    public GameObject[] hearts;
    private int life;


    // Start is called before the first frame update
    void Start()
    {
        
        life = hearts.Length;
        if (PlayerPrefs.GetFloat("CheckpointX") != 0)
        {
            transform.position = new Vector2(PlayerPrefs.GetFloat("CheckpointX", checkpointX), PlayerPrefs.GetFloat("CheckpointY", checkpointY));
        }

    }

    private void CheckLifes()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
            animator.Play("HitAnim");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
            animator.Play("HitAnim");
        }else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
            animator.Play("HitAnim");
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
        life -= 1;
        CheckLifes();
    }
}
