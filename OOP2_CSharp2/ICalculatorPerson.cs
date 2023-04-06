using System;

namespace OOP2_CSharp
{
    internal partial class Program
    {
        interface ICalculatorable 
        {
            void Name();
            void Salary();
            void VacationDays();

        }
        class Proqraming : ICalculatorable
        {

            public void Name()
            {
                throw new NotImplementedException();
            }

            public void Salary()
            {
                throw new NotImplementedException();
            }

            public void VacationDays()
            {
                throw new NotImplementedException();
            }
        }
        class Design : ICalculatorable
        {
            public void Name()
            {
                throw new NotImplementedException();
            }

            public void Salary()
            {
                throw new NotImplementedException();
            }

            public void VacationDays()
            {
                throw new NotImplementedException();
            }
        }
        class Manager : ICalculatorable
        {
            public void Name()
            {
                throw new NotImplementedException();
            }

            public void Salary()
            {
                throw new NotImplementedException();
            }

            public void VacationDays()
            {
                throw new NotImplementedException();
            }
        }

    }


}
