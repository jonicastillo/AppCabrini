using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PrivilegeType { none, vision, edition }

public class Privilege
{
    public PrivilegeType cubScouter;
    public PrivilegeType scoutScouter;
    public PrivilegeType riderScouter;
    public PrivilegeType roverScouter;
    public PrivilegeType scouterPayments;
    public PrivilegeType groupFund;
    public PrivilegeType fixedFund;
}
