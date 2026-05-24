namespace PayrollApp;

public sealed record PayrollResult(
    string ContractorName,
    decimal HoursWorked,
    int Dependents,
    decimal GrossPay,
    decimal UifDeduction,
    decimal PayeDeduction,
    decimal MembershipFee,
    decimal TotalDeductions,
    decimal NetPay);
