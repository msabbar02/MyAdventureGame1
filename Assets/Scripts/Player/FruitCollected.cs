using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FruitCollected : MonoBehaviour
{
    
    public AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false; 
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            FindObjectOfType<FruitManager>().AllFruitsCollected();
            Destroy(gameObject, 0.5f);
            audioSource.Play();
        }
    }
}