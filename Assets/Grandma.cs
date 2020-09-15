using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grandma : MonoBehaviour
{
    public Text grandmaText;
    public ClickerScript cs;
    public float cooldownTimer = 1.0f;
    public int amountOfGrandmas;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ClickerScript>();
        amountOfGrandmas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        grandmaText.text = "Grandmas:\t" + amountOfGrandmas;

        if (amountOfGrandmas > 0)
        {
            grandma();
        }

    }

    void grandma()
    {
        if (cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
        }
        else if (cooldownTimer <= 0)
        {
            cs.cookieCounter = cs.cookieCounter + amountOfGrandmas;
            cooldownTimer = 1.0f;
        }
    }

    public void onClick()
    {
        if (cs.cookieCounter >= 50)
        {
            cs.cookieCounter = cs.cookieCounter - 50;
            amountOfGrandmas++;
        }
    }
}

