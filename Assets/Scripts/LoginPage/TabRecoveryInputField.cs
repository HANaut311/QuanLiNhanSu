using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TabRecoveryInputField : MonoBehaviour
{
    [SerializeField] TMP_InputField email;
    // [SerializeField] Button back;
    [SerializeField] Button recovery;
    [SerializeField] RecoveryPlayfab recover;
    private int inputSelected;

    void OnEnable()
    {
        email.Select();

    }

    void Start()
    {
        email.Select();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            inputSelected --;
            if(inputSelected <0) inputSelected = 1;
            //select
            SelectInputField();
        }
        else if(Input.GetKeyDown(KeyCode.Tab))
        {
            inputSelected ++;
            if(inputSelected > 1) inputSelected = 0;

            //select
            SelectInputField();
        }
        else if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {   
            recover.RecoveryUser();
        }
        // else if(Input.GetKeyDown(KeyCode.Escape))
        // {
        //     recover.OnRe();
        // }

    }

    void SelectInputField()
    {
        switch(inputSelected)
        {
            case 0: email.Select();
                break;
            // case 1: back.Select();
            //     break;
            case 1: recovery.Select();
                break;

        }
    }

    public void EmailSelected() => inputSelected = 0;
    // public void BackSelected() => inputSelected = 1;
    public void RecoverySelected() => inputSelected = 1;

}
