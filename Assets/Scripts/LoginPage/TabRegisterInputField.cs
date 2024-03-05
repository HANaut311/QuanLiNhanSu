using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TabRegisterInputField : MonoBehaviour
{
    [SerializeField] TMP_InputField userName;
    [SerializeField] TMP_InputField email;
    [SerializeField] TMP_InputField passWord;
    [SerializeField] TMP_Dropdown loaiTaiKhoan;
    [SerializeField] Button register;
    // [SerializeField] Button back;
    [SerializeField] RegisterPlayfab registerPage;
    private int inputSelected;

    void OnEnable()
    {
        userName.Select();

    }

    void Start()
    {
        userName.Select();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            inputSelected --;
            if(inputSelected <0) inputSelected = 4;
            //select
            SelectInputField();
        }
        else if(Input.GetKeyDown(KeyCode.Tab))
        {
            inputSelected ++;
            if(inputSelected > 4) inputSelected = 0;

            //select
            SelectInputField();
        }
        else if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {   
            registerPage.RegisterUser();
        }
        // else if(Input.GetKeyDown(KeyCode.Escape))
        // {
        //     registerPage.OpenLoginPage();

        // }

    }

    void SelectInputField()
    {
        switch(inputSelected)
        {
            case 0: userName.Select();
                break;
            case 1: email.Select();
                break;
            case 2: passWord.Select();
                break;
            case 3: loaiTaiKhoan.Select();
                break;
            case 4: register.Select();
                break;    
            // case 4: back.Select();
            //     break;        
        }
    }

    public void UserNameSelected() => inputSelected = 0;
    public void EmailSelected() => inputSelected = 1;
    public void PassWordSelected() => inputSelected = 2;
    public void LoaiTaiKhoanSelected() => inputSelected = 3;
    public void RegisterSelected() => inputSelected = 4;
    // public void BackSelected() => inputSelected = 4;


}
