using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Account
{
    private int balance;
    public Account()
    {
        balance = 0;
    }
    public int Balance
    {
        get
        {
            return balance;
        }
    }
    public void AddFunds(int fundsToAdd)
    {
        if (fundsToAdd < 0)
        {
            throw new System.ArgumentOutOfRangeException("Negative funds are not accepted, use SubtractFunds() instead");
        }
        else
        {
            balance += fundsToAdd;
        }
    }
    public void SubstractFunds(int fundsToSubstract)
    {
        if (fundsToSubstract < 0)
        {
            throw new System.ArgumentOutOfRangeException("Negative withdraws are not accepted");
        }
        else
        {
            balance -= fundsToSubstract;
        }
    }
}
