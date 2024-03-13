using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject player;
    
    // Update is called once per frame
    void Update()
    {
        player.transform.Rotate(2f, 0, 0);    
    }
}
