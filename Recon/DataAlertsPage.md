# Recon Data Alerts Page Documentation

## Components

1. **Macro Tab**
   - **Type:** Tab
   - **Description:** Tab containing the macro-level data and alerts.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      1. **Macro Grid**
         - **Type:** Grid
         - **Description:** Displays list of alerts.
         - **Events:**
           - None
         - **Visibility:**
           - Displayed within the Macro Tab
         - **Components:**
            1. **Impact Type Column**
               - **Type:** Column
               - **Description:** Column for displaying the impact type of an alert.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Impact Type Label**
                     - **Type:** Label
                     - **Description:** Displays the impact type of an alert.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        - None

            2. **Severity Column**
               - **Type:** Column
               - **Description:** Column for displaying the severity of an alert.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Severity Label**
                     - **Type:** Label
                     - **Description:** Displays the severity level of an alert.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        - None

            3. **Alert Column**
               - **Type:** Column
               - **Description:** Column for displaying alerts.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Alert Label**
                     - **Type:** Label
                     - **Description:** Displays the alert message.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        - None

            4. **Remedy Column**
               - **Type:** Column
               - **Description:** Column for displaying potential remedies for alerts.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Remedy Label**
                     - **Type:** Label
                     - **Description:** Displays the recommended action to address the alert.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        - None

      2. **Loans Grid**
         - **Type:** Grid
         - **Description:** Displays list of loans.
         - **Events:**
           - None
         - **Visibility:**
           - Displayed within the Macro Tab
         - **Components:**
            1. **Loan Number Link**
               - **Type:** Link
               - **Description:** Link to view loan details.
               - **Events:**
                 - **on-click:** Navigates to the Loan Details Page.
               - **Visibility:**
                 - Always visible
               - **Components:**
                  - None

2. **Loan Level Tab**
   - **Type:** Tab
   - **Description:** Tab containing loan-level data.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      1. **Loans Grid**
         - **Type:** Grid
         - **Description:** Displays list of loans.
         - **Events:**
           - None
         - **Visibility:**
           - Displayed within the Loan Level Tab
         - **Components:**
            1. **Loan ID Column**
               - **Type:** Column
               - **Description:** Column for displaying the loan ID.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Loan ID Link**
                     - **Type:** Link
                     - **Description:** Link to navigate to the Loan Details Page.
                     - **Events:**
                       - **on-click:** Navigates to the Loan Details Page.
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        - None

            2. **Borrower Last Name Column**
               - **Type:** Column
               - **Description:** Column for displaying the borrower's last name.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  - None

            3. **Impact Type Column**
               - **Type:** Column
               - **Description:** Column for displaying the impact type of a loan.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  - None

            4. **Severity Column**
               - **Type:** Column
               - **Description:** Column for displaying the severity of a loan.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  - None

            5. **Alert Column**
               - **Type:** Column
               - **Description:** Column for displaying loan alerts.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  - None

            6. **Remedy Column**
               - **Type:** Column
               - **Description:** Column for displaying potential remedies for loan issues.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  - None