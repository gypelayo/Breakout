using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataMonobehaviour : MonoBehaviour
{
    private Account account;
    private Text balanceText;
    private
    void Start()
    {
        account = new Account();
        account.AddFunds(PlayerPrefs.GetInt("Account Balance"));
        balanceText = GetComponent<Text>();
        balanceText.text = account.Balance.ToString() + "€";
    }

}
