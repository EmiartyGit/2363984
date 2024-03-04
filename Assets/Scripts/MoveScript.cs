using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveScript : MonoBehaviour
{
    public int speed = 10;
    public int speed1 = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed);
        transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed1);
    }
}
