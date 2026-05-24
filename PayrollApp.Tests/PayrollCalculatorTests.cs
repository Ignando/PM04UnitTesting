using PayrollApp;

namespace PayrollApp.Tests;

[TestClass]
public sealed class PayrollCalculatorTests
{
    [TestMethod]
    public void Unit_GrossPay_UsesHoursAndHourlyRate()
    {
        Assert.AreEqual(7600.00m, PayrollCalculator.CalculateGrossPay(8m));
    }

    [TestMethod]
    public void Unit_Uif_IsOnePercentOfGrossPay()
    {
        Assert.AreEqual(76.00m, PayrollCalculator.CalculateUif(7600.00m));
    }

    [TestMethod]
    public void Unit_MembershipFee_IsThirteenPercentOfGrossPay()
    {
        Assert.AreEqual(988.00m, PayrollCalculator.CalculateMembershipFee(7600.00m));
    }

    [TestMethod]
    public void Unit_Paye_AppliesDependentReliefBeforeTaxRate()
    {
        Assert.AreEqual(1681.50m, PayrollCalculator.CalculatePaye(7600.00m, 2));
    }

    [TestMethod]
    public void Unit_TotalDeductions_AddsAllDeductions()
    {
        Assert.AreEqual(2745.50m, PayrollCalculator.CalculateTotalDeductions(76.00m, 1681.50m, 988.00m));
    }

    [TestMethod]
    public void Unit_NetPay_SubtractsTotalDeductionsFromGrossPay()
    {
        Assert.AreEqual(4854.50m, PayrollCalculator.CalculateNetPay(7600.00m, 2745.50m));
    }

    [TestMethod]
    public void Integration_InputCalculationAndOutputValuesRemainConsistent()
    {
        var result = PayrollCalculator.Calculate("Lebo Mokoena", 8m, 2);

        Assert.AreEqual("Lebo Mokoena", result.ContractorName);
        Assert.AreEqual(8m, result.HoursWorked);
        Assert.AreEqual(2, result.Dependents);
        Assert.AreEqual(7600.00m, result.GrossPay);
        Assert.AreEqual(76.00m, result.UifDeduction);
        Assert.AreEqual(1681.50m, result.PayeDeduction);
        Assert.AreEqual(988.00m, result.MembershipFee);
        Assert.AreEqual(2745.50m, result.TotalDeductions);
        Assert.AreEqual(4854.50m, result.NetPay);
    }

    [TestMethod]
    public void Regression_ZeroDependentsDoesNotReducePaye()
    {
        var result = PayrollCalculator.Calculate("No Dependents", 10m, 0);

        Assert.AreEqual(9500.00m, result.GrossPay);
        Assert.AreEqual(2375.00m, result.PayeDeduction);
        Assert.AreEqual(5795.00m, result.NetPay);
    }
}
