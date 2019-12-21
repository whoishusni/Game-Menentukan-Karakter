using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public GameObject[] gameobjek;
    private float delayTime = 0.5f;
    private float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delayTime)
        {
            int index = Random.Range(0, gameobjek.Length);
            Instantiate(gameobjek[index], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
