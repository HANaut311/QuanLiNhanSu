using System.Collections;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine;

public class RecoveryPlayfab : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI messageText;

    [Header("Recover")]
    [SerializeField] TMP_InputField emailRecoveryInput;
    // [SerializeField] GameObject recoverPage;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void RecoveryUser()
    {
        var request = new SendAccountRecoveryEmailRequest
        {
            Email = emailRecoveryInput.text,
            TitleId = "A8B49",
        };

        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnRecoverySucces, OnErrorRecovery);

    }

    private void OnErrorRecovery(PlayFabError error)
    {
        messageText.text = "No Email Found";
    }

    private void OnRecoverySucces(SendAccountRecoveryEmailResult result)
    {
        messageText.text = "Recovery Mail Sent";
    }
    


}
