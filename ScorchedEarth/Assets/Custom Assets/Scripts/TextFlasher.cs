using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFlasher : MonoBehaviour {

    private Text targetText;
    private float count = 0;
    private bool flash = false;
    private string goalMessage = "";
    private int currentPos = 0;
    private string currentMessage = "";

    public string GoalMessage { 
        set
        {
            currentMessage = "";
            currentPos = 0;
            count = 0;
            flash = true;
            goalMessage = value;
        } }

    public string StartMessage;

	// Use this for initialization
	void Start () {
        targetText = GetComponent<Text>();
        if (StartMessage != null) GoalMessage = StartMessage;
	}
	
	// Update is called once per frame
	void Update () {
        count += Time.deltaTime;
        if (currentPos < goalMessage.Length && count > 0.04)
        {
            currentPos++;
            currentMessage = goalMessage.Substring(0, currentPos);
            flash = true;
            count = 0;
        }
        else if (count > 0.5f)
        {
            flash = !flash;
            count = 0;
        }
        
        
        if (flash) targetText.text = currentMessage + "█";
        else targetText.text = currentMessage;
    }
}
