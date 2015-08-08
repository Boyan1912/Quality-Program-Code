/*
    Refactor the following class using best practices for organizing straight-line code:

    public class Chef
    {
        private Bowl GetBowl()
        {   
            //... 
        }
        private Carrot GetCarrot()
        {
            //...
        }
        private void Cut(Vegetable potato)
        {
            //...
        }  
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl;
            Peel(potato);

            Peel(carrot);
            bowl = GetBowl();
            Cut(potato);
            Cut(carrot);
            bowl.Add(carrot);

            bowl.Add(potato);
        }
        private Potato GetPotato()
        {
            //...
        }
    }

*/

public class Chef
{
    private Bowl GetBowl()
    {
        //... 
    }
    private Carrot GetCarrot()
    {
        //...
    }
    private void Cut(Vegetable potato)
    {
        //...
    }
    private Potato GetPotato()
    {
        //...
    }
    public void Cook()
    {
        Bowl cooksBowl = GetBowl();
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();

        Potato peeledPotato = Peel(potato);
        Carrot peeledCarrot = Peel(carrot);
        
        Potato cutPotato = Cut(peeledPotato);
        Carrot cutCarrot = Cut(cutCarrot);

        cooksBowl.Add(cutPotato);
        cooksBowl.Add(cutCarrot);
    }
    
}
