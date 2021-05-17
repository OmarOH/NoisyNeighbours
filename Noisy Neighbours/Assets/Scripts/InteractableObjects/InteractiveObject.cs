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
    public Sprite idleSpr;
    public Sprite activeSpr;
    public Text text;

    private void Start()
    {
        //radius = obj.radius;
        //timer = obj.timer;
        //idleSpr = obj.idleSprite;
        //activeSpr = obj.activeSprite;
        //idleSpr = GetComponent<Sprite>();
        //activeSpr = GetComponent<Sprite>();
        //text = text.GetComponent<Text>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("space") && triggered)
        {
            if (onState)
            {
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

    public void TurnOn()
    {
        Debug.Log("on");
        onState = true;
        //text.text = timer.ToString();
        gameObject.GetComponent<SpriteRenderer>().sprite = activeSpr;
    }

    public void TurnOff()
    {
        Debug.Log("off");
        onState = false;
        gameObject.GetComponent<SpriteRenderer>().sprite = idleSpr;
    }

    void CountdownTimer(float time)
    {

    }
}
