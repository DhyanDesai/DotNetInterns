namespace DotNetInterns
{
    class Marks{
        public void markCal(){
            
            /*Program to read rollno,name and marks of three subjects and calculate the total,percentage and division*/

            Console.WriteLine("Enter name of the student:");
            string studNameInput = Console.ReadLine();
            Console.WriteLine("Enter Roll no of the student:");
            int studRollInput =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks in maths:");
            int studMarkMathInput =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks in physics:");
            int studMarkPhyInput =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks in chemistry:");
            int studMarkChemInput =  Convert.ToInt32(Console.ReadLine());

            int totalMarks = studMarkMathInput + studMarkPhyInput + studMarkChemInput;
            Console.WriteLine("Total marks of student named {0},roll no {1} are: {2}",studNameInput,studRollInput,totalMarks);
            if(studMarkMathInput >= 33 && studMarkChemInput >= 33 && studMarkPhyInput >=33)
            {
                double percentageMarks = (double)totalMarks / 3;
                Console.WriteLine("Percentage of student named {0},roll no {1} are: {2}%",studNameInput,studRollInput,percentageMarks);
                if(percentageMarks >= 90){
                    Console.WriteLine("Student named {0},roll no {1} has passed the exam in first division",studNameInput,studRollInput);
                }
                else if(percentageMarks >= 75 && percentageMarks <90){
                    Console.WriteLine("Student named {0},roll no {1} has passed the exam in second division",studNameInput,studRollInput);
                }
                else if(percentageMarks >= 50 && percentageMarks <75){
                    Console.WriteLine("Student named {0},roll no {1} has passed the exam in third division",studNameInput,studRollInput);
                }
                else if(percentageMarks >= 33 && percentageMarks <50){
                    Console.WriteLine("Student named {0},roll no {1} has passed the exam in fourth division",studNameInput,studRollInput);
                }else{
                    Console.WriteLine("Student named {0},roll no {1} has failed the exam",studNameInput,studRollInput);
                }
            }else{                
                Console.WriteLine("Student named {0},roll no {1} has failed the exam",studNameInput,studRollInput);
            }
        }
    }
}