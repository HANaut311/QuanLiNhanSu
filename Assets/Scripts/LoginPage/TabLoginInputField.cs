using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TabLoginInputField : MonoBehaviour
{
    [SerializeField] TMP_InputField email;
    [SerializeField] TMP_InputField password;
    [SerializeField] Button login;
    // [SerializeField] Button recovery;
    // [SerializeField] Button register;
    [SerializeField] LoginPagePlayfab loginPage;
    private int inputSelected;
    private bool hasSelected = false;

    void OnEnable()
    {
        if (!hasSelected)
        {
            StartCoroutine(SelectUserNameDelayed());
        }
        else
            email.Select();
    }

    IEnumerator SelectUserNameDelayed()
    {
        yield return null;
        
        email.Select();
        hasSelected = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            inputSelected --;
            if(inputSelected <0) inputSelected = 2;
            //select
            SelectInputField();
        }
        else if(Input.GetKeyDown(KeyCode.Tab))
        {
            inputSelected ++;
            if(inputSelected > 2) inputSelected = 0;

            //select
            SelectInputField();
        }
        else if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {   
            loginPage.Login();
        }

    }

    void SelectInputField()
    {
        switch(inputSelected)
        {
            case 0: email.Select();
                break;
            case 1: password.Select();
                break;
            // case 2: recovery.Select();
            //     break;
            case 2: login.Select();
                break;
            // case 4: register.Select();
            //     break;
        }
    }

    public void EmailSelected()
    {
        inputSelected = 0;
        // hasSelected = true;
    } 
    public void PassWordSelected() 
    {
        inputSelected = 1;
        // hasSelected = true;

    }
    // public void RecoverySelected()
    // {
    //     inputSelected =2;
    //     // hasSelected = true;

    // } 
    public void LoginSelected() 
    {
        inputSelected = 2;
        // hasSelected = true;

    } 
    // public void RegisterSelected() 
    // {
    //     inputSelected = 4;
    //     // hasSelected = true;

    // } 
    

}
