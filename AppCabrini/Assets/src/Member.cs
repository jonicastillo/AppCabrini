using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Section { cub, scout, rider, rover, scouter, other }

public class Member
{
    public Fee monthlyFee;
    public Fee summerCampFee;
    public Fee membershipFee;
    public string name;
    public Date birth;
    public int phoneNumber;
    public Section section;


    public string GetSectionName()
    {
        switch (section)
        {
            case Section.cub:
                return "Lobato";

            case Section.scout:
                return "Scout";

            case Section.rider:
                return "Caminante";

            case Section.rover:
                return "Rover";

            case Section.scouter:
                return "Dirigente";
            case Section.other:

                return "Otro";
        }
        return "null";
    }
}
