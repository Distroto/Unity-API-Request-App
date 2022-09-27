using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Newtonsoft.Json;

[System.Serializable]
public class ResponseData
{
    public ClientData[] users;
}

[System.Serializable]
public class ClientData
{
    public int id ;
    public string name ;
    public string email ;
    public string gender ;
    public string status ;

}
