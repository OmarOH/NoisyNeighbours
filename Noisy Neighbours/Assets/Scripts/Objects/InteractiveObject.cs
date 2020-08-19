using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InteractiveObject : MonoBehaviour
{
    //public ObjectsData obj;
    public float radius;
    public float timer;
    public float countdown;
    public bool triggered = false;
    public bool onState;
    public SpriteRenderer idleSpr;
    public SpriteRenderer activeSpr;
    public Text text;

    private void Start()
    {
        //radius = obj.radius;
        //timer = obj.timer;
        //idleSpr = obj.idleSprite;
        //activeSpr = obj.activeSprite;
        //idleSpr = GetComponent<SpriteRenderer>();
        //activeSpr = GetComponent<SpriteRenderer>();
        text = text.GetComponent<Text>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("space") && triggered)
        {
            if (onState)
            {
                Debug.Log("registered");
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;   
    }

    void TurnOn()
    {
        onState = true;
        text.text = timer.ToString();
        gameObject.GetComponent<SpriteRenderer>().sprite = activeSpr.sprite;
    }

    void TurnOff()
    {
        onState = false;

        gameObject.GetComponent<SpriteRenderer>().sprite = idleSpr.sprite;
    }

    void CountdownTimer(float time)
    {

    }
}
