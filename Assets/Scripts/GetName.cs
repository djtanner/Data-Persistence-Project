using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetName : MonoBehaviour
{
    public TMP_InputField input;

    // Start is called before the first frame update
    void Start()
    {
        

   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getName()
    {
        NameManager.Instance.playerName = input.text;

    }
}
