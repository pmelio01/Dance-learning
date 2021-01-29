using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AuthManager : MonoBehaviour
{
    [Header("Camera for clip selection")]
    public GameObject Vcam2;

    //Firebase variables
    //[Header("Firebase")]
    //public DependencyStatus dependencyStatus;
    //public FirebaseAuth auth;
    //public FirebaseUser User;

    //Login variables
    //[Header("Login")]
    //public TMP_InputField loginEmail;
    //public TMP_InputField loginPassword;

    //[Header("Register")]
    // public TMP_InputField registerName;
    //public TMP_InputField registerEmail;
    //public TMP_InputField registerPassword;
    //public TMP_InputField registerConfirmPassword;


    private void Awake()
    {
        
    }


    public void LoginButton()
    {
       
        Vcam2.SetActive(true);
    }


    public void RegisterButton()
    {
        //MUST FIX IT
        //StartCoroutine(Register(registerName.text, registerEmail.text, registerPassword.text));
        //UIManager.instance.LoginScreen();
    }

}
