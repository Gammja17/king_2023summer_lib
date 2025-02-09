/*
Programmer : KangSYEON
      Date : 7/6/2023
   Purpose : I/O .ini File
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniEx : MonoBehaviour
{
    void Start()
    {
        IniFile ini = new IniFile("Test.ini");
        
        ini.Write("TEST", "Test1", "test1");
        ini.Write("TEST", "Test2", "test2");
        ini.Write("DELETE", "del", "del");
        
        string test1 = ini.Read("SECTION", "Key", "5");
        string test2 = ini.Read("TEST", "Test2");
        
        Debug.Log("data : " + test1 + " dtype : " + test1.GetType());
        Debug.Log("data : " + test2 + " dtype : " + test2.GetType());
        
        ini.DeleteKey("Test", "Test1");
        ini.DeleteSection("DELETE");
        
        ini.ViewFile();
        
        Debug.Log(ini.IsKeyExist("TEST", "Test1"));
    }
}
