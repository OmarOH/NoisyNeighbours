using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Interactive Object", order = 1)]
public class ObjectsData : ScriptableObject
{
    public float timer;
    public float radius;
    public AudioSource sound;
    public SpriteRenderer idleSprite;
    public SpriteRenderer activeSprite;
}
