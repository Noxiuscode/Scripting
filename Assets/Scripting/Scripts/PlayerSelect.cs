using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{

    public bool enableSelectCharacter;

    public enum Player { dinodino, moradino};
    public Player playerSelected;

    public SpriteRenderer spriteRenderer;
    public Animator animator;

    public RuntimeAnimatorController[] playersController;

    public Sprite[] playersRenderer;
    void Start()
    {

        if(!enableSelectCharacter)
        {
            ChangePlayerInMenu();
        }

        else
        {
            switch (playerSelected)
            {
                case Player.dinodino:
                    spriteRenderer.sprite = playersRenderer[0];
                    animator.runtimeAnimatorController = playersController[0];
                    break;

                case Player.moradino:
                    spriteRenderer.sprite = playersRenderer[1];
                    animator.runtimeAnimatorController = playersController[1];
                    break;

                default:
                    break;

            }
        }
     
    }


    public void ChangePlayerInMenu()
    {
        switch (PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Dinodino":
                spriteRenderer.sprite = playersRenderer[0];
                animator.runtimeAnimatorController = playersController[0];
                break;

            case "Moradino":
                spriteRenderer.sprite = playersRenderer[1];
                animator.runtimeAnimatorController = playersController[1];
                break;

            default:
                break;

        }
    }


}
