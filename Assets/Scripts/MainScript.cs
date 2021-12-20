using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MainScript : MonoBehaviour
{

    [DllImport("universal")]
    private static extern int FreeUnjail(int FWVersion);
    [DllImport("universal")]
    private static extern int GetUid();
    [DllImport("universal")]
    private static extern string GetIDPS();
    [DllImport("universal")]
    private static extern string GetPSID();
    [DllImport("universal")]
    private static extern int SendMessageToPS4(string Message);
    [DllImport("universal")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    private static extern string GetUsername();
    [DllImport("universal")]
    //will return the version as e.g.905 //this version can be spoofed
    private static extern int get_fw();
    [DllImport("universal")]
    //will return the version as e.g.905 //this version can't be spoofed
    private static extern UInt16 get_firmware();
    [DllImport("universal")]
    private static extern int FreeMount();

    [DllImport("universal")]
    private static extern int FreeFTP();

    [DllImport("universal")]
    private static extern int Temperature();

    // Use this for initialization
    void Start()
    {
        //for PS4 we want to unjail the app
        if (Application.platform == RuntimePlatform.PS4)
        {
            try
            {

                //This will unjail anything up untill the latest release of universal
                //get firmware will get the latest firmware on the console
                FreeUnjail(get_firmware());

                //This will enable FTP on the console
                FreeFTP();
                //This will Mount the system read write
                FreeMount();

                //Display a notification on the ps4
                SendMessageToPS4("Hello World");
            }
            catch (Exception ex)
            {
                //txtError.text += ex.Message;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        //here you can capture controler input and then display the info for the user

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            return;
        }
        //Controler O Button
        else if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Keypad6))
        {

        }
        //Controler /\
        else if (Input.GetKeyDown(KeyCode.Joystick1Button3) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            return;
        }
        //Controler []
        else if (Input.GetKeyDown(KeyCode.Joystick1Button2) || Input.GetKeyDown(KeyCode.Keypad4))
        {
                       
            return;
        }
        //Controler [   ] middle bar
        else if (Input.GetKeyDown(KeyCode.Joystick1Button6) || Input.GetKeyDown(KeyCode.Space))
        {

        }
        //Controler options
        else if (Input.GetKeyDown(KeyCode.Joystick1Button7) || Input.GetKeyDown(KeyCode.RightAlt))
        {

        }
        //Controler L1
        else if (Input.GetKeyDown(KeyCode.Joystick1Button4) || Input.GetKeyDown(KeyCode.LeftControl))
        {

        }
        //Controler R1
        else if (Input.GetKeyDown(KeyCode.Joystick1Button5) || Input.GetKeyDown(KeyCode.RightControl))
        {

        }
        //Controler right arrow
        else if (Input.GetKeyDown(KeyCode.Joystick1Button11) || Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        //Controler left arrow
        else if (Input.GetKeyDown(KeyCode.Joystick1Button13) || Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        //Controler up arrow
        else if (Input.GetKeyDown(KeyCode.Joystick1Button10) || Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
        //Controler down arrow
        else if (Input.GetKeyDown(KeyCode.Joystick1Button12) || Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
        //Controler L3
        else if (Input.GetKeyDown(KeyCode.Joystick1Button8) || Input.GetKey(KeyCode.LeftAlt))
        {

        }
        //Controler R3
        else if (Input.GetKeyDown(KeyCode.Joystick1Button9) || Input.GetKey(KeyCode.Mouse0))
        {
            return;
        }
        else
        {
            //unkown button
        }
    }
}
