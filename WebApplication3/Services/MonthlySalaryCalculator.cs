namespace Week6_Q_InjectDep.Services
{
    public class MonthlySalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(double yearlyAmount)
        {
            return yearlyAmount / 12;
        }
    }
}
