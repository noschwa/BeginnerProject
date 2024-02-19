using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject ToggleButton;
    public GameObject Button;
    public GameObject ButtonSlotLever;
    public TMPro.TextMeshProUGUI GameText;
    public GameObject SlotWindow0;
    public GameObject SlotWindow1;
    public GameObject SlotWindow2;
    void Start()
    {
        ToggleButton.GetComponent<Button>().interactable = false;

    }

    public void ToggleText()
    {
        if (GameText.text == "What'd ya get?!")
        {
            GameText.text = "Sorry, try again! :)";
        }
        else
        {
            GameText.text = "What'd ya get?!";
        }
    }

    public void PullSlotLever()
    {
        SlotWindow0.GetComponent<SlotRoller>().RollSlots();
        SlotWindow1.GetComponent<SlotRoller>().RollSlots();
        SlotWindow2.GetComponent<SlotRoller>().RollSlots();

    }

    void Update()
    {

    }

    public void DisableLever()
    {
        ButtonSlotLever.GetComponent<Button>().interactable = false;
    }

    public void EnableLever()
    {
        ButtonSlotLever.GetComponent<Button>().interactable = true;
    }

}
