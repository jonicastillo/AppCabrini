using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundManager
{
    private static FundManager _instance;

    public static FundManager instance { get { return Instance(); } }

    public List<Fund> funds = new List<Fund>();


    private static FundManager Instance()
    {
        if (_instance == null)
            _instance = new FundManager();

        return _instance;
    }


    private FundManager()
    {    
        funds.Add(CreateFund("Fondo de grupo", 10000));
        funds.Add(CreateFund("Afiliación", 0));
        funds.Add(CreateFund("Campamento largo", 0));
    }


    private Fund CreateFund(string name, float initialValue)
    {
        var fund = new Fund(name, initialValue);
        return fund;
    }


    public float GetGroupFund()
    {
        return funds[K.FUND_GROUP].value + MembersManager.instance.GetTotalMonthlyFee();
    }


    public float GetMembershipFund()
    {
        return funds[K.FUND_MEMBERSHIP].value + MembersManager.instance.GetTotalMembershipFee();
    }


    public float GetSummerCampFee()
    {
        return funds[K.FUND_SUMMER_CAMP].value + MembersManager.instance.GetTotalSummerCampFee();
    }
}
