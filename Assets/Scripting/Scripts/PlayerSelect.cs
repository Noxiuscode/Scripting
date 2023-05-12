using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    

    public enum Player { dinodino, moradino};
    public Player playerSelected;

    public SpriteRenderer spriteRenderer;

    public Sprite[] playersRenderer;
    void Start()
    {
        switch (playerSelected)
        {
            case Player.dinodino:
                spriteRenderer.sprite = playersRenderer[0];
                break;

            case Player.moradino:
                spriteRenderer.sprite = playersRenderer[1];
                break;

            default:
                break;

        }
    }


}
