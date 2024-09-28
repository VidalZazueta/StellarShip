using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoSomething : MonoBehaviour,IInteractable
{
    // Start is called before the first frame update
    public void Interact()
    {
        Debug.Log(Random.Range(0, 200));
        
    }

    
}
