using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTile : MonoBehaviour
{
    public Sprite highlightSprite;
    public Sprite sprite;
    bool mouseOver = false;

     public void OnMouseOver()
     {
            mouseOver = true;
            GetComponent<SpriteRenderer>().sprite = highlightSprite;

     }

    public void OnMouseExit()
    {
            mouseOver = false;
            GetComponent<SpriteRenderer>().sprite = sprite;
    }

}
