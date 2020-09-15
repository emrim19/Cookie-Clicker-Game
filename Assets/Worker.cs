using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Worker : MonoBehaviour
{
    public Text workerText;
    public ClickerScript cs;
    public float cooldownTimer = 1.0f;
    public int amountOfWorkers;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ClickerScript>();
        amountOfWorkers = 0;
    }

    // Update is called once per frame
    void Update()
    {
        workerText.text = "Workers:\t\t" + amountOfWorkers;

        if(amountOfWorkers > 0)
        {
            worker();
        }
        
    }

    void worker()
    {
        if (cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
        }
        else if (cooldownTimer <= 0)
        {
            cs.cookieCounter = cs.cookieCounter + (amountOfWorkers * 25);
            cooldownTimer = 1.0f;
        }
    }

    public void onClick()
    {
        if(cs.cookieCounter >= 1000)
        {
            cs.cookieCounter = cs.cookieCounter - 1000;
            amountOfWorkers++;
        }
    }
}
