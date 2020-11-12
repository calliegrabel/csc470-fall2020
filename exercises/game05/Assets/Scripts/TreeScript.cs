using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
   
    public bool selected = false;
    public bool hover = false;

    public Color defaultColor;
    public Color hoverColor;
    public Color selectedColor;

    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        UpdateVisuals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateVisuals()
    {
        if (selected)
        {
            rend.material.color = selectedColor;
        }
        else
        {
            if(hover)
            {
                rend.material.color = hoverColor;
            }
            else
            {
                rend.material.color = defaultColor;
            }
        }
    }
    private void OnMouseEnter()
    {
        hover = true;
        UpdateVisuals();
    }
    private void OnMouseExit()
    {
        hover = false;
        UpdateVisuals();
    }
    private void OnMouseDown()
    {
        selected = !selected;
        if (selected)
        {
            //cut or grow trees
        }
    }
}
