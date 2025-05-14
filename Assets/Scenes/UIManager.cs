using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class UI : MonoBehaviour

{
public Animator StartButton;
public Animator SettingsButton;
public Animator SettingsDialog;

   public void StartGame() 
{
    SceneManager.LoadScene("practice");

}
public void OpenSettings() 
{


    StartButton.SetBool("IsHidden", true);
    SettingsButton.SetBool("IsHidden", true);
    SettingsDialog.SetBool("IsHidden", false);
}
public void CloseSettings() 
{
    StartButton.SetBool("IsHidden", false);
    SettingsButton.SetBool("IsHidden", false);
    SettingsDialog.SetBool("IsHidden", true);
}
}
