using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{

    public SpriteRenderer sp;
    public Text header;
    public float timer = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        sp.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer < 1)
        {
            sp.color = Color.red;
            header.color = Color.green;
        }
        else if(timer >= 1 && timer < 2)
        {
            sp.color = Color.blue;
            header.color = Color.yellow;
        }
        else if (timer >= 2 && timer < 3)
        {
            sp.color = Color.yellow;
            header.color = Color.red;
        }
        else if (timer >= 3 && timer < 4)
        {
            sp.color = Color.green;
            header.color = Color.blue;
        }
        else if(timer > 4)
        {
            timer = 0;
        }


    }
}
