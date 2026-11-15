using System;

public class Progrem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person[] people = new Person[5];

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (HaveSharedChildren(people[i], people[j]))
                    {
                        Console.WriteLine(people[i].GetPassport().GetFirstName() + " ו-" + people[j].GetPassport().GetFirstName());
                    }
                }
            }
        }


        public static bool HaveSharedChildren(Person p1, Person p2)
        {
            string[] kids1 = p1.GetPassport().GetChildrensIDNumbers();
            int count1 = p1.GetPassport().GetChildrenCount();

            string[] kids2 = p2.GetPassport().GetChildrensIDNumbers();
            int count2 = p2.GetPassport().GetChildrenCount();

            for (int i = 0; i < count1; i++)
            {
                for (int j = 0; j < count2; j++)
                {
                    if (kids1[i] == kids2[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

}

