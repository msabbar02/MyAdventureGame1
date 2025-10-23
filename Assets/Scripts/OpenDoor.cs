using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    
    public TextMeshProUGUI text;
    public string levelname;
    public bool inDoor = false;
    
    public AudioSource audioSource;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            text.gameObject.SetActive(true);
            inDoor = true;
            audioSource.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            text.gameObject.SetActive(false);
            inDoor = false; 
            audioSource.Stop();
        }
    }


    private void Update()
    {
        if (inDoor && Input.GetKey("e"))
        {
            SceneManager.LoadScene(levelname);
        }
    }
}
