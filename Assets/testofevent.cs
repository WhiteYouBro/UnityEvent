using DG.Tweening;
using System;
using aaaa;
using UnityEngine;

public class testofevent : MonoBehaviour
{
    private Action a;
    // Start is called before the first frame update
    void Start()
    {
        a = MoveToRight;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            a.Invoke();
        if(Input.GetKeyDown(KeyCode.A))
            a = MoveToLeft;
    }
    
    void MoveToRight()
    {
        transform.DOMove(new Vector2(10, 0), duration:2);
    }

    void MoveToLeft()
    {
        transform.DOMove(new Vector2(-10, 0), duration: 2);
    }
}
