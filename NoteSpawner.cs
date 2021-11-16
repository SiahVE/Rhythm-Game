using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefabs;

    void Start()
    {
       
    }

    void Update()
    {
        
    }

    public void NoteSpawn()
    {
        GameObject Notes = Instantiate(notePrefabs, transform.position, transform.rotation) as GameObject;
    }
}
