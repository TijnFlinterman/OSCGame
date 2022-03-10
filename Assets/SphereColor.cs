using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColor : MonoBehaviour
{
    public Material sphereMaterial;
    Color StartC;

    [SerializeField] [Range(0f, 1f)] float lerpTime;
    [ColorUsage(true, true)] [SerializeField] Color[] myColors;

    int colorIndex = 0;
    private bool hasToggled1 = false;
    private bool hasToggled2 = false;
    private bool hasToggled3 = false;
    private bool hasToggled4 = false;

    void Update()
    {
        StartC = Color.Lerp(StartC, myColors[colorIndex], lerpTime * Time.deltaTime);
        sphereMaterial.SetColor("Color_1c43478757b444f4b0fc56c2c6645ee4", StartC);

        if (Gamemanager.main.diffcultyAmount >= 0 && hasToggled1 == false)
        {
            hasToggled1 = true;
        }
        if (Gamemanager.main.diffcultyAmount >= 2 && hasToggled2 == false)
        {
            colorIndex++;
            hasToggled2 = true;
        }
        if (Gamemanager.main.diffcultyAmount >= 5 && hasToggled3 == false)
        {
            colorIndex++;
            hasToggled3 = true;
        }
        if (Gamemanager.main.diffcultyAmount >= 9 && hasToggled4 == false)
        {
            colorIndex++;
            hasToggled4 = true;
        }
    }
}

