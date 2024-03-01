namespace DotNetInterns
{
    class UserLogin{
        public void userAuth(){
            /*that takes userid and password as input and After 3 unsuccessful attempts the user will be rejected.*/

            string userId = "DhyanDesai",password = "pass1234",userIdInput,passwordInput;
            for(int i= 1;i<=3;i++){
                Console.WriteLine("Enter username");
                userIdInput = Console.ReadLine();
                Console.WriteLine("Enter password");
                passwordInput = Console.ReadLine();
                if(userIdInput == userId && passwordInput == password){
                    Console. ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Username and password are correct");
                    Console.ResetColor();
                    break;
                }else{
                    Console. ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Username and password are incorrect,Try again!!");
                    Console.ResetColor();
                    if(i==3){
                        Console. ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Login attempt more than {0} times.Try Later!!!!",i);
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}