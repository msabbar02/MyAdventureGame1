using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitManager : MonoBehaviour
{
    public TextMeshProUGUI levelCleared;
    public GameObject transition;
    public void update()
    {
        AllFruitsCollected();
    }
    public void AllFruitsCollected()
    {
        if(transform.childCount == 1)
        {
           
            levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene",1);
            
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
