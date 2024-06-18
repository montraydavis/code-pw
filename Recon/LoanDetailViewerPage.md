# Recon Loan Detail Viewer Page Documentation

## Components

1. **Loan Search Input**
   - **Type:** Input
   - **Description:** Input to filter loans by Borrower Name or Loan Number.
   - **Events:**
     - **on-change:** Updates the Loans Grid to filter loans by Borrower Name or Loan Number.
   - **Visibility:**
     - Always visible.
   - **Components:**
      None

2. **Search Button**
   - **Type:** Button
   - **Description:** Button to search for loans.
   - **Events:**
     - None specified.
   - **Visibility:**
     - Always visible.
   - **Components:**
      None

3. **Transformed Values Tab**
   - **Type:** Tab
   - **Description:** Tab displaying the transformed values for a list of loans.
   - **Events:**
     - None specified.
   - **Visibility:**
     - Always visible.
   - **Components:**
      1. **Loans Grid**
         - **Type:** Grid
         - **Description:** Displays transformed values for a list of loans.
         - **Events:**
           - None specified.
         - **Visibility:**
           - Always visible.
         - **Components:**
            1. **Loan Number Link**
               - **Type:** Link
               - **Description:** Link to view loan details.
               - **Events:**
                 - None specified.
               - **Visibility:**
                 - Always visible.
               - **Components:**
                  None

4. **Raw Loan Values Tab**
   - **Type:** Tab
   - **Description:** Tab displaying the raw values for a list of loans.
   - **Events:**
     - None specified.
   - **Visibility:**
     - Always visible.
   - **Components:**
      1. **Loans Grid**
         - **Type:** Grid
         - **Description:** Displays a list of loans.
         - **Events:**
           - None specified.
         - **Visibility:**
           - Always visible.
         - **Components:**
            None