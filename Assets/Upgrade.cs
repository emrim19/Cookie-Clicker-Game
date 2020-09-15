using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public Text upgradeText;
    public ClickerScript cs;
    public int amountOfUpgrades;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ClickerScript>();
        amountOfUpgrades = 0;
    }

    // Update is called once per frame
    void Update()
    {
        upgradeText.text = "Upgrades:\t" + amountOfUpgrades;
    }

    public void onClick()
    {
        if(cs.cookieCounter >= 200)
        {
            cs.cookieCounter = cs.cookieCounter - 200;
            amountOfUpgrades++;
        }
    }

}
