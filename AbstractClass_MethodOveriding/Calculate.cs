using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClass_MethodOverloading
{
    public abstract class Calculate
    {
        public abstract void Add(double a, double b, double c);
        public abstract void Subtract(double a, double b);
        public virtual void Multiply(double a){
            //method overriding 
        }
        public virtual void Divide(double a, double b){
            //method over riding
        }
      
    }
}