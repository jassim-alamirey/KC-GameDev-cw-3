using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3_if : MonoBehaviour
{

    //hero info
    string heroName = "Codeman";
    int heroPower = 100;

    //villian info
    string villanName = "Mr.Evil";
    int villanPower = 50;

    float playerSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (villanPower > heroPower)
        {
            print("villian is  stronger");
        }
        else if (villanPower < heroPower)
        {
            print("hero  is stronger");
        }
        else
        {
            print("they are equal");
        }

        SetSpeed(2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetSpeed( float speed)
    {
        print(playerSpeed);
        playerSpeed = speed;
        print(playerSpeed);
    }
}
