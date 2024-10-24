using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*public class Survey : MonoBehaviour
{
    [SerializeField] InputField feedback1;
    public string inputText;

  

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLScQ77D66o9Sr2wIBEW_ltYwyHXgbCtY1HDTUIAZUytluUkJqA/formResponse";

    void Start()
    {
        Button yesButton = GameObject.Find("YesButton").GetComponent<Button>();
        Button noButton = GameObject.Find("NoButton").GetComponent<Button>();

        if (yesButton != null)
        {
            yesButton.onClick.RemoveAllListeners(); 
            yesButton.onClick.AddListener(() => Send("Yes")); 
        }
        else
        {
            Debug.LogError("YesButton no encontrado en la escena.");
        }

        if (noButton != null)
        {
            noButton.onClick.RemoveAllListeners(); 
            noButton.onClick.AddListener(() => Send("No")); 
        }
        else
        {
            Debug.LogError("NoButton no encontrado en la escena.");
        }
    }

    public void Send(string response)
    {
        StartCoroutine(Post(response, feedback1.text));
        Debug.Log(response);
        Debug.Log(feedback1.text);
        inputText = feedback1.text;
        feedback1.text = " ";
    }

    IEnumerator Post(string response,string s1)
    {
        Debug.Log("Post called with response: " + response);
        WWWForm form = new WWWForm();
        form.AddField("entry.938277337", response);
        form.AddField("entry.528194267", s1);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error: " + www.error);
        }
        else
        {
            Debug.Log("Response sent successfully");
        }
    }
}*/

/*public class Survey : MonoBehaviour
{

    [SerializeField] InputField feedback1;
    public string inputText;


    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLScQ77D66o9Sr2wIBEW_ltYwyHXgbCtY1HDTUIAZUytluUkJqA/formResponse";


    public void Send()
    {
       StartCoroutine(Post(feedback1.text));
       Debug.Log(feedback1.text);
       inputText = feedback1.text;
        feedback1.text = " ";

    }



    IEnumerator Post(string s1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.528194267", s1);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

    }

}*/


/*public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Text myText;
    public TMP_InputField myInputField;
    public string inputText;

    // Start is called before the first frame update
    //void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    {
        
    }

    public void ReadStringInput(string s)
    {
       
    }

    public void ButtonPress()
    {
        Debug.Log(myInputField.text);

        inputText = myInputField.text;
        myInputField.text = " ";

    }

}  */

/*public class Survey : MonoBehaviour  // con TEXT
{

    [SerializeField] InputField feedback1;
    public string inputTextt;
    public string inputTexta;
    public TMP_Text mytext;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLScQ77D66o9Sr2wIBEW_ltYwyHXgbCtY1HDTUIAZUytluUkJqA/formResponse";


    public void SendtextA()
    {
        StartCoroutine(Post(mytext.text));
        Debug.Log(mytext.text);
        inputTextt = mytext.text;
     

    }

    public void Sendinpu()
    {
        StartCoroutine(Postt(feedback1.text));
        Debug.Log(feedback1.text);
        inputTexta = feedback1.text;
        feedback1.text = " ";

    }


    IEnumerator Post(string s1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.116256300", s1);


        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

    }


    IEnumerator Postt(string s2)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.528194267", s2);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

    }
}*/


/*public class Survey : MonoBehaviour  // SIN TEXT CON LOS BOTONES YES NO
{

    [SerializeField] InputField feedback1;
    public string inputTextt;
    public string inputTexta;
    public TMP_Text mytext;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLScQ77D66o9Sr2wIBEW_ltYwyHXgbCtY1HDTUIAZUytluUkJqA/formResponse";

    void Start()
    {
        Button yesButton = GameObject.Find("YesButton").GetComponent<Button>();
        Button noButton = GameObject.Find("NoButton").GetComponent<Button>();

        if (yesButton != null)
        {
            yesButton.onClick.RemoveAllListeners();
            yesButton.onClick.AddListener(() => Send("Yes"));
        }
        else
        {
            Debug.LogError("YesButton no encontrado en la escena.");
        }

        if (noButton != null)
        {
            noButton.onClick.RemoveAllListeners();
            noButton.onClick.AddListener(() => Send("No"));
        }
        else
        {
            Debug.LogError("NoButton no encontrado en la escena.");
        }
    }


    public void SendFixA()
    {
        string fixAt = "A";
        StartCoroutine(Post(fixAt));
        Debug.Log(fixAt);
    }

    public void Sendinpu()
    {
        StartCoroutine(Postt(feedback1.text));
        Debug.Log(feedback1.text);
        inputTexta = feedback1.text;
        feedback1.text = " ";

    }

    public void Send(string response)
    {
        StartCoroutine(Posty(response));
        Debug.Log(response);
       
    }

    IEnumerator Post(string s1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.116256300", s1);


        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

    }


    IEnumerator Postt(string s2)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.528194267", s2);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

    }

    IEnumerator Posty(string response)
    {
        Debug.Log("Post called with response: " + response);
        WWWForm form = new WWWForm();
        form.AddField("entry.938277337", response);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error: " + www.error);
        }
        else
        {
            Debug.Log("Response sent successfully");
        }
    }


}*/



/*public class Survey : MonoBehaviour  // PRUEBA CON YES
{

    [SerializeField] InputField feedback1;
    public string inputTextt;
    public string inputTexta;
    public TMP_Text mytext;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLScQ77D66o9Sr2wIBEW_ltYwyHXgbCtY1HDTUIAZUytluUkJqA/formResponse";

  
    public void SendFixYes()
    {
        string fixAt = "Yes";
        StartCoroutine(Post(fixAt));
        Debug.Log(fixAt);
    }


    IEnumerator Post(string s1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.938277337", s1);


        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

    }
   

}*/


/*public class Survey : MonoBehaviour  // SIN TEXT CON LOS BOTONES YES NO ESTE ES EL MEJOR 20/10 ESTE ES EL QUE ES
{

    [SerializeField] InputField feedback1;
    public string inputTextt;
    public string inputTexta;
    public TMP_Text mytext;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLScQ77D66o9Sr2wIBEW_ltYwyHXgbCtY1HDTUIAZUytluUkJqA/formResponse";

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void SendFixA()
    {
        string fixAt = "A";
        StartCoroutine(Posta(fixAt));
        Debug.Log(fixAt);
    }

    public void Sendinpu()
    {
        StartCoroutine(Posti(feedback1.text));
        Debug.Log(feedback1.text);
        inputTexta = feedback1.text;
        feedback1.text = " ";

    }

    public void SendFixyes()
    {
        string fixYes = "Yes";
        StartCoroutine(Postye(fixYes));
        Debug.Log(fixYes);
    }

    public void SendFixNo()
    {
        string fixno = "No";
        StartCoroutine(Postno(fixno));
        Debug.Log(fixno);
    }

    IEnumerator Posta(string s1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.116256300", s1);


        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

    }


    IEnumerator Posti(string s2)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.528194267", s2);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

    }

    IEnumerator Postye(string s3)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.938277337", s3);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

    }

    IEnumerator Postno(string s4)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.938277337", s4);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

    }


}*/



public class Survey : MonoBehaviour
{
    List<string> ItemsList = new List<string> { "lo", "la", "lak", "lik", "lok" };
    List<string> namezone = new List<string> { "ama", "omo", "li", "la", "lolo" };

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSeVuNbzJnf9qp9EbRVvF7zLhkEnfLOWcak4FhfWTWo23c343Q/formResponse";


    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Sendinpu()
    {
        StartCoroutine(SendItemsWithDelay());
    }

    IEnumerator SendItemsWithDelay()
    {
        for (int i = 0; i < ItemsList.Count; i++)
        {
            // Envía el elemento actual
            StartCoroutine(Posti(ItemsList[i], namezone[i]));
            Debug.Log(ItemsList[i] + " - " + namezone[i] + "\n");

            // Espera 10 segundos antes de continuar con el siguiente elemento
            yield return new WaitForSeconds(4f);
        }
    }

    IEnumerator Posti(string s2, string s3)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.2086070314", s2);
        form.AddField("entry.458115288", s3); // Reemplaza XXXXXX con el entry correspondiente para `namezone`

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("Error al enviar datos: " + www.error);
        }
        else
        {
            Debug.Log("Datos enviados correctamente: " + www.downloadHandler.text);
        }
    }
}