using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeClick : MonoBehaviour
{

    public GameObject player;
    public Sprite newSprite;

    private SpriteRenderer sRend;

	// Use this for initialization
	void Start ()
    {
        sRend = player.GetComponent<SpriteRenderer>();
	}

    void OnMouseDown()
    {
        sRend.sprite = newSprite;

    }
	

}
