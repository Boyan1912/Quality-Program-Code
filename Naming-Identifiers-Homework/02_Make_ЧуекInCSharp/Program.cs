/*

    Refactor the following examples to produce code with well-named C# identifiers.

    class Hauptklasse
    {
      enum Пол { ултра_Батка, Яка_Мацка };
      class чуек
      {
        public Пол пол { get; set; }
        public string име_на_Чуека { get; set; }
        public int Възраст { get; set; }
      }       
      public void Make_Чуек(int магическия_НомерНаЕДИНЧОВЕК)
      {
        чуек new_Чуек = new чуек();
        new_Чуек.Възраст = магическия_НомерНаЕДИНЧОВЕК;
        if (магическия_НомерНаЕДИНЧОВЕК%2 == 0)
        {
          new_Чуек.име_на_Чуека = "Батката";
          new_Чуек.пол = Пол.ултра_Батка;
        }
        else
        {
          new_Чуек.име_на_Чуека = "Мацето";
          new_Чуек.пол = Пол.Яка_Мацка;
        }
      }
    }

*/

using System;
using System.Globalization;
using System.Text;
class General
{
    public enum Gendre
    {
        male, female
    };
    public class Person
    {
        public Gendre Sex { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public void MakePerson(int personIdNumber)
    {
        Person someone = new Person();
        
        someone.Age = DetermineAge(personIdNumber);

        if (personIdNumber % 2 == 0)
        {
            someone.Name = "Батката";
            someone.Sex = Gendre.male;
        }
        else
        {
            someone.Name = "Мацето";
            someone.Sex = Gendre.female;
        }
        
    }
    
}

