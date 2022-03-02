
using UnityEngine;
using System.Collections;
using Firebase.Analytics;
using Firebase.Extensions;
using Firebase.Auth;
using UnityEngine.UI;
using Firebase.Database;
using Firebase;
public class AuthManager : MonoBehaviour
{
    public Text logText;
    public Button SignInButton, SignUpButton;
    public InputField email, password;
    public GameObject panel;
    private DatabaseReference dbReference;
    public Text MensajeLog;



    // User info
    FirebaseUser userActual;
    public InputField CorreoUsuario;
    public InputField Nombres;
    public InputField Apellidos;
    public InputField Dni;
    private void Start()
    {


        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            Firebase.DependencyStatus dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {

                dbReference = FirebaseDatabase.DefaultInstance.RootReference;

            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
                // Firebase Unity SDK is not safe to use here.
            }
        });

    }
    public void OnclickLogin()
    {

        FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync(email.text, password.text).ContinueWithOnMainThread(task =>
        {
            if (task.IsCanceled)
            {
                Debug.Log("SignInWithEmailAndPasswordAsync was canceled.");

                MensajeLog.text = "No se ha podido Ingresar";
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);

                MensajeLog.text = "No se ha podido Ingresar";
                return;
            }


            MensajeLog.text = "Inicio Exitoso";
            Firebase.Auth.FirebaseUser newUser = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);
            OnclickShowDetails();
            LoadData();
            panel.SetActive(false);
            



        });


    }
    public void OnclickCreate()
    {
 
        FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync(email.text, password.text).ContinueWithOnMainThread(task =>
        {
            if (task.IsCanceled)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                MensajeLog.text = "No se ha podido Crear cuenta";
                return;
            }
            if (task.IsFaulted)
            {

                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);

                return;

            }

            if(task.IsCompleted)
            {
                // Firebase user has been created.
                Firebase.Auth.FirebaseUser newUser = task.Result;
                Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);
                MensajeLog.text = "Cuenta Creada con exito";
                OnclickLogin();
                OnclickShowDetails();
                SaveDataUsuario();
              
               
                
                panel.SetActive(false);



            }
        });


    }
    public void OnclickShowDetails()
    {

         userActual = FirebaseAuth.DefaultInstance.CurrentUser;
        if (userActual != null)
        {
            CorreoUsuario.text = userActual.Email;
            string email = userActual.Email;

            System.Uri photo_url = userActual.PhotoUrl;
            // The user's Id, unique to the Firebase project.
            // Do NOT use this value to authenticate with your backend server, if you
            // have one; use User.TokenAsync() instead.
            string uid = userActual.UserId;

            Debug.Log(userActual.Email);
            // CorreoUsuario.interactable = false;
        }



    }




    public void SaveDataUsuario()
    {
        User user = new User();
        user.correousuariocreado = email.text;
        user.nombreusuariocreado = Nombres.text;
        user.DniDeusuario = Dni.text;
        user.ApellidosDeusuario = Apellidos.text;
        string json = JsonUtility.ToJson(user);
        Debug.Log(json);
      
            dbReference.Child("users").Child(userActual.UserId).SetRawJsonValueAsync(json);
            Dni.interactable = false;
            Apellidos.interactable = false;
            Nombres.interactable = false;
       

    }
    public void LoadData() => dbReference.Child("users").Child(userActual.UserId).GetValueAsync().ContinueWithOnMainThread(task =>
                          {

                              if (task.IsCompleted)
                              {
                                  DataSnapshot snapShot = task.Result;
                                  Dni.text = snapShot.Child("DniDeusuario").Value.ToString();
                                  Apellidos.text= snapShot.Child("ApellidosDeusuario").Value.ToString();
                                  Nombres.text= snapShot.Child("nombreusuariocreado").Value.ToString();
                                  CorreoUsuario.text= snapShot.Child("correousuariocreado").Value.ToString();
                              }

                          });

    public void Modify()
    {
        Dni.interactable = true;
        Apellidos.interactable = true;
        Nombres.interactable = true;
    }

}









