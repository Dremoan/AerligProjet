using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FillingLight : MonoBehaviour {

    public UnityEvent clicAnim;
    public UnityEvent triggerAnim;
    [SerializeField] bool animDone;


    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && !animDone)
        {
            clicAnim.Invoke();
            animDone = true;
        }
    }
    public void startAnim()
    {
        triggerAnim.Invoke();
    }
}
