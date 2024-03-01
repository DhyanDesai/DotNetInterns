namespace DotNetInterns
{
    class Armstrong
    {
        public void armstrong(){
            int numberCheckArmstrong,reminderArmstrong,tempStore;
            double totalArmstrong = 0;
            Console.WriteLine("Enter a number");
            numberCheckArmstrong = Convert.ToInt32(Console.ReadLine());
            tempStore = numberCheckArmstrong;
            while(numberCheckArmstrong > 0){
                reminderArmstrong = numberCheckArmstrong % 10;
                totalArmstrong += Math.Pow(reminderArmstrong,3);
                numberCheckArmstrong = numberCheckArmstrong / 10;
            }
            if (tempStore == totalArmstrong){
                Console.WriteLine("Armstrong number");
            }else{
                Console.WriteLine("not a Armstrong");
            }
        }
    }
}