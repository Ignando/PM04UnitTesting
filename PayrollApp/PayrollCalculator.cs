namespace PayrollApp;

public static class PayrollCalculator
{
    public const decimal HourlyRate = 950.00m;
    public const decimal UifRate = 0.01m;
    public const decimal DependentReliefRate = 0.0575m;
    public const decimal PayeRate = 0.25m;
    public const decimal MembershipRate = 0.13m;

    public static decimal CalculateGrossPay(decimal hoursWorked)
    {
        return RoundCurrency(hoursWorked * HourlyRate);
    }

    public static decimal CalculateUif(decimal grossPay)
    {
        return RoundCurrency(grossPay * UifRate);
    }

    public static decimal CalculatePaye(decimal grossPay, int dependents)
    {
        var taxableAmount = grossPay - (grossPay * DependentReliefRate * dependents);
        return RoundCurrency(taxableAmount * PayeRate);
    }

    public static decimal CalculateMembershipFee(decimal grossPay)
    {
        return RoundCurrency(grossPay * MembershipRate);
    }

    public static decimal CalculateTotalDeductions(decimal uif, decimal paye, decimal membershipFee)
    {
        return RoundCurrency(uif + paye + membershipFee);
    }

    public static decimal CalculateNetPay(decimal grossPay, decimal totalDeductions)
    {
        return RoundCurrency(grossPay - totalDeductions);
    }

    public static PayrollResult Calculate(string contractorName, decimal hoursWorked, int dependents)
    {
        var grossPay = CalculateGrossPay(hoursWorked);
        var uif = CalculateUif(grossPay);
        var paye = CalculatePaye(grossPay, dependents);
        var membershipFee = CalculateMembershipFee(grossPay);
        var totalDeductions = CalculateTotalDeductions(uif, paye, membershipFee);
        var netPay = CalculateNetPay(grossPay, totalDeductions);

        return new PayrollResult(
            contractorName.Trim(),
            hoursWorked,
            dependents,
            grossPay,
            uif,
            paye,
            membershipFee,
            totalDeductions,
            netPay);
    }

    private static decimal RoundCurrency(decimal value)
    {
        return Math.Round(value, 2, MidpointRounding.AwayFromZero);
    }
}
