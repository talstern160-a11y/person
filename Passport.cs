using System;
public class Passport
{
    private string iDNumber;
    private string firstName;
    private string lastName;
    private Date dateOfBirth;          
    private string countryOfBirth;
    private string nation;
    private string maritalStatus;
    private string residentialAddress;
    private string[] childrensIDnumbers;
    private int childrenCount;

    public Passport(string idNumber, string firstName, string lastName, Date dateOfBirth,
                    string countryOfBirth, string nation, string maritalStatus,
                    string residentialAddress, string[] childrensIDnumbers)
    {
        this.iDNumber = idNumber;
        this.firstName = firstName;
        this.lastName = lastName;
        this.dateOfBirth = dateOfBirth;
        this.countryOfBirth = countryOfBirth;
        this.nation = nation;
        this.maritalStatus = maritalStatus;
        this.residentialAddress = residentialAddress;
        this.childrensIDnumbers = childrensIDnumbers;

        if (childrensIDnumbers != null)
        {
            this.childrenCount = childrensIDnumbers.Length;
        }
        else
        {
            this.childrenCount = 0;
        }
    }


    public string GetIDNumber()
    {
        return this.iDNumber;
    }
    public void SetIDNumber(string idNumber)
    {
        this.iDNumber = idNumber;
    }

    public string GetFirstName()
    {
        return this.firstName;
    }
    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public string GetLastName()
    {
        return this.lastName;
    }
    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public Date GetDateOfBirth()
    {
        return this.dateOfBirth;
    }
    public void SetDateOfBirth(Date dateOfBirth)
    {
        this.dateOfBirth = dateOfBirth;
    }

    public string GetCountryOfBirth()
    {
        return this.countryOfBirth;
    }
    public void SetCountryOfBirth(string countryOfBirth)
    {
        this.countryOfBirth = countryOfBirth;
    }

    public string GetNation()
    {
        return this.nation;
    }
    public void SetNation(string nation)
    {
        this.nation = nation;
    }

    public string GetMaritalStatus()
    {
        return this.maritalStatus;
    }
    public void SetMaritalStatus(string maritalStatus)
    {
        this.maritalStatus = maritalStatus;
    }

    public string GetResidentialAddress()
    {
        return this.residentialAddress;
    }
    public void SetResidentialAddress(string residentialAddress)
    {
        this.residentialAddress = residentialAddress;
    }

    public string[] GetChildrensIDNumbers()
    {
        return this.childrensIDnumbers;
    }
    public void SetChildrensIDNumbers(string[] childrensIDnumbers)
    {
        this.childrensIDnumbers = childrensIDnumbers;
        if (childrensIDnumbers != null)
        {
            this.childrenCount = childrensIDnumbers.Length;
        }
        else
        {
            this.childrenCount = 0;
        }
    }

    public int GetChildrenCount()
    {
        return this.childrenCount;
    }
    public void SetChildrenCount(int childrenCount)
    {
        this.childrenCount = childrenCount;
    }
    public bool AddChild(string childId)
    {
        if (this.childrenCount < 3)
        {
            this.childrensIDnumbers[this.childrenCount] = childId;
            this.childrenCount++;
            return true;
        }
        return false;
    }

    public bool RemoveChild(string childId)
    {
        for (int i = 0; i < this.childrenCount; i++)
        {
            if (this.childrensIDnumbers[i] == childId)
            {
                for (int j = i; j < this.childrenCount - 1; j++)
                {
                    this.childrensIDnumbers[j] = this.childrensIDnumbers[j + 1];
                }
                this.childrensIDnumbers[this.childrenCount - 1] = null;
                this.childrenCount--;
                return true;
            }
        }
        return false;
    }
}
