using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitManager : MonoBehaviour
{

    public void update()
    {
        AllFruitsCollected();
    }
    public void AllFruitsCollected()
    {
        if(transform.childCount == 1)
        {
            Debug.Log("All fruits collected");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
