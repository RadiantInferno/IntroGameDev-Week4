using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    private int rand;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        rand = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + ++i);
        if (i == 100 && gameObject.CompareTag("Red")) gameObject.SetActive(false);
        if (i == rand && gameObject.CompareTag("Blue")) rend.enabled = false;
    }
}
