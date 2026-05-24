namespace PayrollApp;

using System.Globalization;

public static class PayrollInputValidator
{
    public const int MaximumDependents = 10;

    public static bool TryValidate(
        string contractorName,
        string hoursText,
        string dependentsText,
        out decimal hoursWorked,
        out int dependents,
        out string errorMessage)
    {
        hoursWorked = 0m;
        dependents = 0;

        if (string.IsNullOrWhiteSpace(contractorName))
        {
            errorMessage = "Contractor name is required.";
            return false;
        }

        if (!TryParseDecimal(hoursText, out hoursWorked))
        {
            errorMessage = "Hours worked must be a numeric value.";
            return false;
        }

        if (hoursWorked < 0m)
        {
            errorMessage = "Hours worked cannot be negative.";
            return false;
        }

        if (!int.TryParse(dependentsText, out dependents))
        {
            errorMessage = "Dependents must be a whole numeric value.";
            return false;
        }

        if (dependents < 0)
        {
            errorMessage = "Dependents cannot be negative.";
            return false;
        }

        if (dependents > MaximumDependents)
        {
            errorMessage = $"Dependents cannot exceed {MaximumDependents}.";
            return false;
        }

        errorMessage = string.Empty;
        return true;
    }

    private static bool TryParseDecimal(string value, out decimal result)
    {
        return decimal.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out result)
            || decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out result);
    }
}
