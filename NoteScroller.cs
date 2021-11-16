using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScroller : MonoBehaviour
{
    public float noteTempo;
    public bool hasStarted;

    void Start()
    {
        noteTempo = noteTempo / 60f;
    }

    void Update()
    {
        if (hasStarted)
        {
            transform.position -= new Vector3(0f, noteTempo * Time.deltaTime, 0f);
        }
    }
}
