using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MembersManager
{
    private static MembersManager _instance;
    private List<Member> _members = new List<Member>();

    public static MembersManager instance { get { return GetInstance(); } }


    private MembersManager() { }


    private static MembersManager GetInstance()
    {
        if (_instance == null)
            _instance = new MembersManager();

        return _instance;
    }


    public void AddMember(Member member)
    {
        _members.Add(member);
    }


    public float GetTotalMonthlyFee()
    {
        var total = 0f;
        for (int i = 0; i < _members.Count; i++)
        {
            total += _members[i].monthlyFee.value;
        }

        return total;
    }


    public float GetTotalMembershipFee()
    {
        var total = 0f;
        for (int i = 0; i < _members.Count; i++)
        {
            total += _members[i].membershipFee.value;
        }

        return total;
    }


    public float GetTotalSummerCampFee()
    {
        var total = 0f;
        for (int i = 0; i < _members.Count; i++)
        {
            total += _members[i].summerCampFee.value;
        }

        return total;
    }
}
