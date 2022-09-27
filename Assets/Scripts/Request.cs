using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Newtonsoft.Json;

public class Request : MonoBehaviour
{
    private string url = "https://gorest.co.in/public/v2/users";

    public void GetData()
    {
        StartCoroutine(DataRequest());
    }

    public Text id;
    public Text name;
    public Text email;
    public Text gender;
    public Text status;

    IEnumerator DataRequest() 
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        if(request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {

            
            ResponseData responseData = JsonConvert.DeserializeObject<ResponseData>("{\"users\":" + request.downloadHandler.text + "}");

            //Using Random function to get random user data

            int i = Random.Range(0, responseData.users.Length);

            //Displaying the data and assigning it to the respective text fields

            id.text = responseData.users[i].id.ToString();
            name.text = responseData.users[i].name.ToString();
            email.text = responseData.users[i].email.ToString();
            gender.text = responseData.users[i].gender.ToString();
            status.text = responseData.users[i].status.ToString();

        }
    }
}


