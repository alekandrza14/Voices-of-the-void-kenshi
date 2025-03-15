using System.IO;
using UnityEngine;
public enum politicfreedom
{
    NonPositionalian = 0, avtoritatian = 1, lidertatian = 2, democratian = 3, centrarian = 4
}
public enum politiceconomic
{
    NonPositionalian = 0, left = 1, mind = 2, right = 3, bipoly = 4
}

public class PolitDate
{
    static politicfreedom memory;
    static politiceconomic memory2;
    public static politicfreedom IsVersionF()
    {
        politicfreedom now = politicfreedom.lidertatian;
        if (memory == politicfreedom.NonPositionalian)
        {
            if (File.Exists("PoliticSettings.ini"))
            {
                now = (politicfreedom)int.Parse(File.ReadAllLines("PoliticSettings.ini")[1]);
                memory = now;
            }
        }
        else
        {
            now = memory;
        }
        return now;
    }
    public static politiceconomic IsVersionE()
    {
        politiceconomic now = politiceconomic.left;
        if (memory2 == politiceconomic.NonPositionalian)
        {
            if (File.Exists("PoliticSettings.ini"))
            {
                now = (politiceconomic)int.Parse(File.ReadAllLines("PoliticSettings.ini")[3]);
                memory2 = now;
            }
        }
        else
        {
            now = memory2;
        }
        return now;
    }
    public static bool IsGoodF(politicfreedom politic)
    {
        bool now = false;
        if (IsVersionF() == politicfreedom.centrarian)
        {
            if (politic == politicfreedom.centrarian)
            {
                now = true;
            }
            else
            {
                now = false;
            }
        }
        if (IsVersionF() == politicfreedom.lidertatian)
        {
            if (politic == politicfreedom.lidertatian)
            {
                now = true;
            }
            else if (politic == politicfreedom.democratian)
            {
                now = true;
            }
            else if (politic == politicfreedom.centrarian)
            {
                now = true;
            }
            else
            {
                now = false;
            }
        }
        if (IsVersionF() == politicfreedom.avtoritatian)
        {
            if (politic == politicfreedom.avtoritatian)
            {
                now = true;
            }
            else if (politic == politicfreedom.democratian)
            {
                now = true;
            }
            else if (politic == politicfreedom.centrarian)
            {
                now = true;
            }
            else
            {
                now = false;
            }
        }
        if (IsVersionF() == politicfreedom.democratian)
        {

            now = true;

        }
        if (IsVersionF() == politicfreedom.NonPositionalian)
        {
            if (politic == politicfreedom.NonPositionalian)
            {
                now = true;
            }
        }
        return now;
    }
    public static bool IsGoodE(politiceconomic politic)
    {
        bool now = false;
        if (IsVersionE() == politiceconomic.right)
        {
            if (politic != politiceconomic.left)
            {
                now = true;
            }
            else if (politic != politiceconomic.bipoly)
            {
                now = true;
            }
            else
            {
                now = false;
            }
        }
        if (IsVersionE() == politiceconomic.mind)
        {
            if (politic != politiceconomic.bipoly)
            {
                now = true;
            }
        }
        if (IsVersionE() == politiceconomic.bipoly)
        {
            if (politic == politiceconomic.bipoly) now = true;
        }
        if (IsVersionE() == politiceconomic.left)
        {
            if (politic == politiceconomic.left)
            {
                now = true;
            }
            else if (politic != politiceconomic.bipoly)
            {
                now = true;
            }
            else
            {
                now = false;
            }
        }

        return now;
    }
}
