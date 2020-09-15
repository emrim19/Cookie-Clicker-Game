using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Factory : MonoBehaviour
{
    public Text factoryText;
    public ClickerScript cs;
    public float cooldownTimer = 1.0f;
    public int amountOfFactories;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ClickerScript>();
        amountOfFactories = 0;
    }

    // Update is called once per frame
    void Update()
    {
        factoryText.text = "Factories:\t" + amountOfFactories;

        if (amountOfFactories > 0)
        {
            factory();
        }

    }

    void factory()
    {
        if (cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
        }
        else if (cooldownTimer <= 0)
        {
            cs.cookieCounter = cs.cookieCounter + (amountOfFactories * 5000);
            cooldownTimer = 1.0f;
        }
    }

    public void onClick()
    {
        if (cs.cookieCounter >= 100000)
        {
            cs.cookieCounter = cs.cookieCounter - 100000;
            amountOfFactories++;
        }
    }
}
