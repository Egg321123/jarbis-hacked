using System;
public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Introduction()
    {
        return ($"My first name is: {FirstName} \n My last name is: {LastName} \n My age is: {Age}");
    }
}
