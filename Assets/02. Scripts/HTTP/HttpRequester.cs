using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


//게시물 정보
[Serializable]
public class PostData
{
    public int userId;
    public int id;
    public string title;
    public string body;
}

[Serializable]
public class PostDataArray
{
    public List<PostData> data;
}

public class UserData
{
    public string name;
    public string id;
    public string email;
    public int age;
    /*
    * {
    *      "name":"김현진",
    *      "id":"rapa_xr",
    *      "email":"lokimve7@naver.com",
    *      "age":20
    * }
    */
}

public enum RequestType
{
    POST,
    GET,
    PUT,
    DELETE
}

public class HttpRequester : MonoBehaviour
{
    //url
    public string url;
    //요청 타입 (GET, POST, PUT, DELETE)
    public RequestType requestType;

    //Post Data 
    public string postData;//(body)

    //응답이 왔을 때 호출해줄 함수 (Action)
    //Action : 함수를 넣을 수 있는 자료형
    public Action<DownloadHandler> onComplete; 
}
