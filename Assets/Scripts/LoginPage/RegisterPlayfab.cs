using System.Collections;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine;

public class RegisterPlayfab : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI messageText;
    [Header("Register")]
    [SerializeField] TMP_InputField userNameRegisterInput;
    [SerializeField] TMP_InputField emailRegisterInput;
    [SerializeField] TMP_InputField passwordRegisterInput;
    
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void RegisterUser()
    {   
        //Neu nguoi dung nhap pass nho hon 6 tu thi bao message text = too short password



        var request = new RegisterPlayFabUserRequest
        {
            DisplayName = userNameRegisterInput.text,
            Email = emailRegisterInput.text,
            Password = passwordRegisterInput.text,

            RequireBothUsernameAndEmail = false
        };

        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSucces, OnError);

    }

    private void OnError(PlayFabError Error)
    {
        messageText.text = Error.ErrorMessage;

        Debug.Log(Error.GenerateErrorReport());
    }

    private void OnRegisterSucces(RegisterPlayFabUserResult Result)
    {
        messageText.text = "New Account Is Created";

    }    

}
