using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor(GameObject g)
    {
        if (g.name == "background")
        {

        }
        spriteRenderer = g.GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color(0f, 0f, 0f, 1f);
    }
}
