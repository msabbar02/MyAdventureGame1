using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerSelect : MonoBehaviour
{
    public bool enableSelectCharacter;
    public enum Player
    {
        Frog,
        VirtualGuy,
        PinkMan
    };
     public Player PlayerSelected;
     
     public Animator animator;
     public SpriteRenderer spriteRenderer;
     
     public RuntimeAnimatorController [] playersController;
     [FormerlySerializedAs("playerSprites")] public Sprite[] playerRenderer;
     
    // Start is called before the first frame update
    void Start()
    {
        if (!enableSelectCharacter)
        {
            ChangePlayerInMenu();

        }
        else
        { 
            switch (PlayerSelected)
            {
                case Player.Frog:
                    spriteRenderer.sprite = playerRenderer[0];
                    animator.runtimeAnimatorController = playersController[0];
                    break;

                case Player.VirtualGuy:
                    spriteRenderer.sprite = playerRenderer[1];
                    animator.runtimeAnimatorController = playersController[1];
                    break;
                case Player.PinkMan:
                    spriteRenderer.sprite = playerRenderer[2];
                    animator.runtimeAnimatorController = playersController[2];
                    break;
            }
        }


    }

    public void ChangePlayerInMenu()
    {
        switch (PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Frog":
                spriteRenderer.sprite = playerRenderer[0];
                animator.runtimeAnimatorController = playersController[0];
                break;

            case  "VirtualGuy":
                spriteRenderer.sprite = playerRenderer[1];
                animator.runtimeAnimatorController = playersController[1];
                break;
            case "PinkMan":
                spriteRenderer.sprite = playerRenderer[2];
                animator.runtimeAnimatorController = playersController[2];
                break;
        }
        
    }
    
}
