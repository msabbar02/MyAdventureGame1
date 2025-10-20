using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitManager : MonoBehaviour
{
    public TextMeshProUGUI levelCleared;
    public GameObject transition;
    
    public TextMeshProUGUI totalFruits;
    public TextMeshProUGUI fruitCount;
    
    private int totalFruitsInNivel;

    public void Start()
    {
        totalFruitsInNivel = transform.childCount;
        
    }

    public void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInNivel.ToString();
        fruitCount.text = transform.childCount.ToString();
    }
    public void AllFruitsCollected()
    {
        if(transform.childCount == 0)
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
