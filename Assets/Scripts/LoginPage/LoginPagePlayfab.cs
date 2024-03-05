using System.Collections;
using TMPro;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginPagePlayfab : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI messageText;

    [Header("Login")]
    [SerializeField] TMP_InputField emailLoginInput;
    [SerializeField] TMP_InputField passwordLoginInput;
    [SerializeField] GameObject loginPage;

    [Header("Register")]
    [SerializeField] TMP_InputField userNameRegisterInput;
    [SerializeField] TMP_InputField emailRegisterInput;
    [SerializeField] TMP_InputField passwordRegisterInput;
    [SerializeField] GameObject registerPage;

    [Header("Recover")]
    [SerializeField] TMP_InputField emailRecoveryInput;
    [SerializeField] GameObject recoverPage;

    [SerializeField] GameManager gameManager;

    [SerializeField] private GameObject welcomePopup;
    [SerializeField] TextMeshProUGUI welcomeText;


    #region Button functions

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    // public void RegisterUser()
    // {   
    //     //Neu nguoi dung nhap pass nho hon 6 tu thi bao message text = too short password



    //     var request = new RegisterPlayFabUserRequest
    //     {
    //         DisplayName = userNameRegisterInput.text,
    //         Email = emailRegisterInput.text,
    //         Password = passwordRegisterInput.text,

    //         RequireBothUsernameAndEmail = false
    //     };

    //     PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSucces, OnError);

    // }

    public void Login()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = emailLoginInput.text,
            Password = passwordLoginInput.text,

            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }

        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSucces, OnError);
    }

    private void OnLoginSucces(LoginResult result)
    {   
        string name = null;
        if(result.InfoResultPayload != null)
            name = result.InfoResultPayload.PlayerProfile.DisplayName;
        
        welcomePopup.SetActive(true);
        //ma de lay ten nguoi dung
        welcomeText.text = "Welcome " + name;

        if(gameManager != null)
        {
            gameManager.playerName = name;
        }
        StartCoroutine(LoadNextScene());
    }

    // public void RecoveryUser()
    // {
    //     var request = new SendAccountRecoveryEmailRequest
    //     {
    //         Email = emailRecoveryInput.text,
    //         TitleId = "A8B49",
    //     };

    //     PlayFabClientAPI.SendAccountRecoveryEmail(request, OnRecoverySucces, OnErrorRecovery);

    // }

    // private void OnErrorRecovery(PlayFabError error)
    // {
    //     messageText.text = "No Email Found";
    // }

    // private void OnRecoverySucces(SendAccountRecoveryEmailResult result)
    // {
    //     OpenLoginPage();
    //     messageText.text = "Recovery Mail Sent";
    // }

    private void OnError(PlayFabError Error)
    {
        messageText.text = Error.ErrorMessage;

        Debug.Log(Error.GenerateErrorReport());
    }

    // private void OnRegisterSucces(RegisterPlayFabUserResult Result)
    // {
    //     messageText.text = "New Account Is Created";
    //     OpenLoginPage();
    // }

    public void OpenLoginPage()
    {
        loginPage.SetActive(true);
        registerPage.SetActive(false);
        recoverPage.SetActive(false);
    }

    // public void OpenRegisterPage()
    // {
    //     loginPage.SetActive(false);
    //     registerPage.SetActive(true);
    //     recoverPage.SetActive(false);    
    
    // }

    // public void OpenRecoveryPage()
    // {
    //     loginPage.SetActive(false);
    //     registerPage.SetActive(false);
    //     recoverPage.SetActive(true);
    // }

#endregion

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(2f);
        messageText.text = "Loggin in";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }



}
