using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkins : MonoBehaviour
{
    public GameObject skinsPanel;
    private bool inDoor =  false;
    public GameObject player;
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            skinsPanel.gameObject.SetActive(true);
            inDoor = true;
            audioSource.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            skinsPanel.gameObject.SetActive(false);
            inDoor = false;
            audioSource.Stop();
        }
    }

    
    
    
    
    public void SetPlayerFrog()
    {
        PlayerPrefs.SetString("PlayerSelected","Frog");
        ResetPlayerSkin();
    }
    
    public void SetPlayerVirtualGuy()
    {
        PlayerPrefs.SetString("PlayerSelected","VirtualGuy");
        ResetPlayerSkin();
        
    }

    public void SetPlayerPinkMan()
    {
        PlayerPrefs.SetString("PlayerSelected","PinkMan");
        ResetPlayerSkin();
        
    }
    
    

    public void ResetPlayerSkin()
    {
        skinsPanel.gameObject.SetActive(false);
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu();
    }
}
