using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotRoller : MonoBehaviour
{
    public Main Main;
    public List<Image> images;
    public float rollDelay;
    public int rollLoops;
    public int variance;

    // event for signalling that roll is done
    public delegate void SlotRollEnd();
    public event SlotRollEnd StopRoll;

    //public TMPro.TextMeshProUGUI MessageText;

    private int listIndex;

    void Start()
    {
        listIndex = 0;
        for (int loopCnt = 0; loopCnt < images.Count; loopCnt++)
        {
            images[loopCnt].enabled = false;
        }
        images[listIndex].enabled = true;
    }

    void Update()
    {

    }

    public void RollSlots()
    {
        Main.DisableLever();

        StartCoroutine(RollSlotsLoop(rollDelay));
    }


    IEnumerator RollSlotsLoop(float delayTime)
    {
        int loopLimit = rollLoops * images.Count + Random.Range(0, variance);

        for (int loopCnt = listIndex; loopCnt < loopLimit; loopCnt++)
        {
            listIndex = loopCnt % images.Count;

            if (listIndex == 0)
            {
                images[images.Count - 1].enabled = false;
            }
            else
            {
                images[listIndex - 1].enabled = false;
                
            }
            images[listIndex].enabled = true;
            yield return new WaitForSeconds(delayTime);
        }
        //DisplayMessage(listIndex);
        this.StopRoll();
        yield return null;
    }
}
