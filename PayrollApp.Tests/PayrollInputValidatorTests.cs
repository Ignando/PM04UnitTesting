using PayrollApp;

namespace PayrollApp.Tests;

[TestClass]
public sealed class PayrollInputValidatorTests
{
    [TestMethod]
    public void Validation_AcceptsValidInput()
    {
        var isValid = PayrollInputValidator.TryValidate(
            "Asha Naidoo",
            "12.5",
            "3",
            out var hoursWorked,
            out var dependents,
            out var errorMessage);

        Assert.IsTrue(isValid);
        Assert.AreEqual(12.5m, hoursWorked);
        Assert.AreEqual(3, dependents);
        Assert.AreEqual(string.Empty, errorMessage);
    }

    [TestMethod]
    [DataRow("", "8", "1", "Contractor name is required.")]
    [DataRow("Asha", "abc", "1", "Hours worked must be a numeric value.")]
    [DataRow("Asha", "-1", "1", "Hours worked cannot be negative.")]
    [DataRow("Asha", "8", "abc", "Dependents must be a whole numeric value.")]
    [DataRow("Asha", "8", "-1", "Dependents cannot be negative.")]
    [DataRow("Asha", "8", "11", "Dependents cannot exceed 10.")]
    public void Validation_RejectsInvalidInput(
        string contractorName,
        string hoursText,
        string dependentsText,
        string expectedError)
    {
        var isValid = PayrollInputValidator.TryValidate(
            contractorName,
            hoursText,
            dependentsText,
            out _,
            out _,
            out var errorMessage);

        Assert.IsFalse(isValid);
        Assert.AreEqual(expectedError, errorMessage);
    }

    [TestMethod]
    public void Retesting_PreviouslyInvalidMaximumDependentsNowAcceptsLimit()
    {
        var isValid = PayrollInputValidator.TryValidate(
            "Asha Naidoo",
            "8",
            "10",
            out _,
            out var dependents,
            out var errorMessage);

        Assert.IsTrue(isValid);
        Assert.AreEqual(10, dependents);
        Assert.AreEqual(string.Empty, errorMessage);
    }
}
