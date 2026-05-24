# Mzansi Tech Contractors Payroll - Test Report

## Test Execution Summary

| Item | Result |
| --- | --- |
| Project tested | PayrollApp |
| Test project | PayrollApp.Tests |
| Test command | `dotnet test MzansiTechPayroll.slnx --no-restore --logger "console;verbosity=normal"` |
| Test date | 2026-05-24 |
| Total automated tests | 16 |
| Passed | 16 |
| Failed | 0 |
| Overall status | Pass |

## Test Cases

| ID | Test case | Test data | Expected result | Actual result | Pass/Fail |
| --- | --- | --- | --- | --- | --- |
| TC01 | Calculate gross pay | 8 hours, hourly rate R950.00 | Gross pay is R7,600.00 | Gross pay was R7,600.00 | Pass |
| TC02 | Calculate UIF deduction | Gross pay R7,600.00 | UIF is 1% = R76.00 | UIF was R76.00 | Pass |
| TC03 | Calculate membership fee | Gross pay R7,600.00 | Membership fee is 13% = R988.00 | Membership fee was R988.00 | Pass |
| TC04 | Calculate PAYE with dependent relief | Gross pay R7,600.00, 2 dependents | PAYE is R1,681.50 | PAYE was R1,681.50 | Pass |
| TC05 | Calculate total deductions | UIF R76.00, PAYE R1,681.50, membership R988.00 | Total deductions are R2,745.50 | Total deductions were R2,745.50 | Pass |
| TC06 | Calculate net pay | Gross pay R7,600.00, deductions R2,745.50 | Net pay is R4,854.50 | Net pay was R4,854.50 | Pass |
| TC07 | Full payroll calculation integration | Lebo Mokoena, 8 hours, 2 dependents | All calculated fields match expected payroll values | All calculated fields matched expected values | Pass |
| TC08 | Accept valid input | Asha Naidoo, 12.5 hours, 3 dependents | Input is accepted with no error message | Input was accepted with no error message | Pass |
| TC09 | Reject missing contractor name | Empty name, 8 hours, 1 dependent | Error: Contractor name is required. | Expected error displayed | Pass |
| TC10 | Reject non-numeric hours | Asha, abc hours, 1 dependent | Error: Hours worked must be a numeric value. | Expected error displayed | Pass |
| TC11 | Reject negative hours | Asha, -1 hours, 1 dependent | Error: Hours worked cannot be negative. | Expected error displayed | Pass |
| TC12 | Reject non-numeric dependents | Asha, 8 hours, abc dependents | Error: Dependents must be a whole numeric value. | Expected error displayed | Pass |
| TC13 | Reject negative dependents | Asha, 8 hours, -1 dependents | Error: Dependents cannot be negative. | Expected error displayed | Pass |
| TC14 | Reject dependents above maximum | Asha, 8 hours, 11 dependents | Error: Dependents cannot exceed 10. | Expected error displayed | Pass |
| TC15 | Regression: zero dependents | No Dependents, 10 hours, 0 dependents | PAYE remains 25% of gross pay and net pay is R5,795.00 | PAYE was R2,375.00 and net pay was R5,795.00 | Pass |
| TC16 | Retest maximum valid dependents | Asha Naidoo, 8 hours, 10 dependents | 10 dependents is accepted | 10 dependents was accepted | Pass |

## Identified Defects

| Defect ID | Defect | Impact | Status |
| --- | --- | --- | --- |
| D01 | Starter project did not contain payroll calculation logic. | The application could not calculate gross pay, deductions, or net pay. | Corrected |
| D02 | Starter project did not validate user input. | Invalid names, hours, and dependents could be processed incorrectly. | Corrected |
| D03 | Starter form did not provide payroll output fields. | Users could not view the calculated payroll results. | Corrected |
| D04 | Running the wrong item may appear to do nothing. The executable app and the test project are separate. | If the test project is not run with `dotnet test` or Test Explorer, test output may not display. | Workaround documented |

## Corrections Made

| Defect ID | Correction made |
| --- | --- |
| D01 | Added `PayrollCalculator` with gross pay, UIF, PAYE, membership fee, total deductions, and net pay calculations. |
| D02 | Added `PayrollInputValidator` to validate required contractor name, numeric hours, non-negative hours, whole-number dependents, non-negative dependents, and maximum dependents. |
| D03 | Updated the Windows Forms payroll screen to accept contractor details and display payroll results. |
| D04 | Confirmed tests run from the solution with `dotnet test MzansiTechPayroll.slnx`. |

## Retesting Results

| Defect ID | Retest performed | Result | Pass/Fail |
| --- | --- | --- | --- |
| D01 | Ran calculator unit tests TC01 to TC06 and integration test TC07. | All expected payroll values matched the actual results. | Pass |
| D02 | Ran validation tests TC08 to TC14. | Valid input was accepted and invalid input was rejected with correct messages. | Pass |
| D03 | Confirmed the payroll app builds successfully together with the test project. | Application project compiled successfully. | Pass |
| D04 | Ran `dotnet test MzansiTechPayroll.slnx --no-restore --logger "console;verbosity=normal"`. | Test runner discovered and executed 16 tests successfully. | Pass |

## Final Result

The payroll application passed all automated tests. No failed test cases remain after correction and retesting.
