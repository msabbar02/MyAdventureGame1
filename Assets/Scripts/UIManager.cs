using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class NewBehaviourScript : MonoBehaviour
{
       public GameObject optionPanel;
       public AudioSource audioSource;

       public void OptionPanel()
       {
              Time.timeScale = 0;
               optionPanel.SetActive(true);
       }

       public void Return()
       {
           Time.timeScale = 1;
           optionPanel.SetActive(false);
       }

       public void AnotherOptionPanel()
       {
           //sound
           //Graphics
       }
       
       public void GoMainMenu()
       {
           Time.timeScale = 1;
           SceneManager.LoadScene("MainMenu");
       }

       public void QuitGame()
       {
           Application.Quit();
       }

       public void PlayMusic()
       {
           audioSource.Play();
       }
}
