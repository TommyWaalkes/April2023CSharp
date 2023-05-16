namespace MockAssessment5.Models
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        //This sets up a condition that listens to the Age property and 
        //Adjusts its value anytime age changes. 
        //Put another way, this create a listener on Age and anytime age changes it re-check this condition automatically
        //Downside is that we can't set the value on canDrink/canDrive directly 
        public bool CanDrink => Age >= 21;
        public bool CanDrive => Age >= 16;
    }
}
