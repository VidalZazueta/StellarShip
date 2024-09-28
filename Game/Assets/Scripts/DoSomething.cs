using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoSomething : MonoBehaviour,IInteractable
{
    int counter = 1;
    // Start is called before the first frame update
    public void Interact()
    {
        Debug.Log("You collected "+counter+" debloons");
        counter++;
        
    }

    
}
