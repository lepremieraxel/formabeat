using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // Change the object's sprite current color, by switching between two colors
    public void SwitchColor()
    {
        Debug.Log("Color Change !"); // write the information "Color Change" in the Console

        SpriteRenderer currentRenderer = GetComponent<SpriteRenderer>(); // get the SpriteRender component situated on the same gameObject

        // Switch between two colors, by testing which one is currently in use, and replacing it by the opposite one
        if (currentRenderer.color == Color.white)
        {
            currentRenderer.color = Color.cyan;
        }
        else
        {
            currentRenderer.color = Color.white;
        }
    }

    // Automatically called by Unity when a user click on the current gameObject (as long as it has a collider attached)
    private void OnMouseDown()
    {
        SwitchColor();
    }
}
