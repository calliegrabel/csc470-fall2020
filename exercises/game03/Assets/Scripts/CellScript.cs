using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour
{
    Renderer rend;
    public Color aliveColor;
    public Color deadColor;
    public int i = -1;
    public int j = -1;
    private bool alive = false;

    public bool Alive
    {
        get
        {
            return this.alive;
        }
        set
        {
            this.alive = value;
            if (this.alive)
            {
                rend.material.color = aliveColor;
            }
            else
            {
                rend.material.color = deadColor;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        this.Alive = Random.value < 0.5f; //half time true half time false
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
