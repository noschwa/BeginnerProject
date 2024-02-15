using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Main Main;
    public GameObject ToggleButton;

    public GameObject ButtonSlotLever;

    public GameObject Button;

    public void ToggleText()
    {
        Main.ToggleText();
    }

    public void ToggleEnable()
    {
        if (ToggleButton.GetComponent<Button>().interactable == false)
        {
            ToggleButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            ToggleButton.GetComponent<Button>().interactable = false;
        }
    }

    public void PullSlotLever()
    {
        Main.PullSlotLever();
    }

}