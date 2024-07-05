namespace Week6_Q_InjectDep.Services
{
    public class QuarterlySalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(double yearlyAmount)
        {
            return yearlyAmount / 4;
        }
    }
}
