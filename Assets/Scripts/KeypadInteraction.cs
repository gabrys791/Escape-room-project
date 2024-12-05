using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class KeypadInteraction : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject button0;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject clear;
    public GameObject enter;
    public AudioSource audioSource;
    public AudioSource fail;
    public AudioSource success;
    public void but1()
    {
        inputField.text = inputField.text + "1";
        audioSource.Play();    
    }
    public void but2()
    {
        inputField.text = inputField.text + "2";
        audioSource.Play();
    }
    public void but3()
    {
        inputField.text = inputField.text + "3";
        audioSource.Play();
    }
    public void but4()
    {
        inputField.text = inputField.text + "4";
        audioSource.Play();
    }
    public void but5()
    {
        inputField.text = inputField.text + "5";
        audioSource.Play();
    }
    public void but6()
    {
        inputField.text = inputField.text + "6";
        audioSource.Play();
    }
    public void but7()
    {
        inputField.text = inputField.text + "7";
        audioSource.Play();
    }
    public void but8()
    {
        inputField.text = inputField.text + "8";
        audioSource.Play();
    }
    public void but9()
    {
        inputField.text = inputField.text + "9";
        audioSource.Play();
    }
    public void but0()
    {
        inputField.text = inputField.text + "0";
        audioSource.Play();
    }
    public void clearBut()
    {
        inputField.text = null;
        audioSource.Play();
    }
    public void EnterBut()
    {
        if(inputField.text == "1397")
        {
            success.Play();
            SceneManager.LoadScene(3);

        }
        else
        {
            inputField.text = null;
            fail.Play();
        }
    }
    public void back()
    {
        SceneManager.LoadScene(1);
    }


}
