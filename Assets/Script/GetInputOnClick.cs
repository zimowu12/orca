using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetInputOnClick : MonoBehaviour
{

    public Button btnClick;

    public TMP_InputField inputUser;

    // Start is called before the first frame update
    private void Start()
    {
        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }

    public void GetInputOnClickHandler()
    {
        Debug.Log("Log input" + inputUser.text);
    }
}
