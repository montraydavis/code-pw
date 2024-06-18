# Ratesheet Page Documentation

## Components

1. **New Ratesheet Details Container**
   - **Type:** Container
   - **Description:** Container to display the new ratesheet details
   - **Events:**
     - **on-load:** Should display this container if the client has no existing ratesheet.
   - **Visibility:**
     - Displayed if the client has no existing ratesheet.
   - **Components:**
     1.1. **Last Created Label**
         - **Type:** Label
         - **Description:** Label to display the last created ratesheet
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     1.2. **TBA Price Label**
         - **Type:** Label
         - **Description:** Label to display the TBA price
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     1.3. **Price Difference Label**
         - **Type:** Label
         - **Description:** Label to display the price difference
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     1.4. **New Locks as of Published Ratesheet (UPB/Count) Label**
         - **Type:** Label
         - **Description:** Label to display the new locks as of the published ratesheet (UPB/Count)
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     1.5. **Current TBA Price Label**
         - **Type:** Label
         - **Description:** Label to display the current TBA price
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     1.6. **Last Ratesheet Posted By Label**
         - **Type:** Label
         - **Description:** Label to display the last ratesheet posted by
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     1.7. **Best Efforts Label**
         - **Type:** Label
         - **Description:** Label to display the best efforts
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     1.8. **Cash Label**
         - **Type:** Label
         - **Description:** Label to display the cash
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     1.9. **Bulk Label**
         - **Type:** Label
         - **Description:** Label to display the bulk
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     1.10. **MBS Label**
         - **Type:** Label
         - **Description:** Label to display the MBS
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     1.11. **Create New Ratesheet Button**
         - **Type:** Button
         - **Description:** Button to create a new ratesheet
         - **Events:**
           - **on-click:** Should open the Create New Ratesheet Confirmation Modal.
         - **Visibility:** Always visible
         - **Components:**
           1.11.1. **Create New Ratesheet Confirmation Modal**
               - **Type:** Modal
               - **Description:** Modal to confirm the creation of a new ratesheet
               - **Events:** None
               - **Visibility:** Visible when triggered by Create New Ratesheet Button click
               - **Components:**
                 1.11.1.1. **Create New Ratesheet Confirmation Label**
                     - **Type:** Label
                     - **Description:** Label to display the create new ratesheet confirmation
                     - **Events:** None
                     - **Visibility:** Always visible within the modal
                     - **Components:** None
                 1.11.1.2. **Create New Ratesheet Button**
                     - **Type:** Button
                     - **Description:** Button to confirm the creation of a new ratesheet
                     - **Events:**
                       - **on-click:** Should close the Create New Ratesheet Confirmation Modal and run the Create New Ratesheet job.
                     - **Visibility:** Always visible within the modal
                     - **Components:** None

2. **Ratesheet Details Container**
   - **Type:** Container
   - **Description:** Container to display the ratesheet details
   - **Events:**
     - **on-load:** Should display this container if the client has an existing ratesheet.
   - **Visibility:**
     - Displayed if the client has an existing ratesheet.
   - **Components:**
     2.1. **Ratehseet Settings Link**
         - **Type:** Link
         - **Description:** Link to navigate to the ratesheet settings
         - **Events:**
           - **on-click:** Should open the Ratesheet Settings Modal.
         - **Visibility:** Always visible
         - **Components:**
           2.1.1. **Ratesheet Settings Modal**
               - **Type:** Modal
               - **Description:** Modal to display the ratesheet settings
               - **Events:** None
               - **Visibility:** Visible when triggered by Ratehseet Settings Link click
               - **Components:**
                 2.1.1.1. **Close Button**
                     - **Type:** Button
                     - **Description:** Button to close the modal
                     - **Events:**
                       - **on-click:** Should close the Ratesheet Settings Modal.
                     - **Visibility:** Always visible within the modal
                     - **Components:** None
                 2.1.1.2. **Price Source Dropdown**
                     - **Type:** Dropdown
                     - **Description:** Dropdown to select the price source
                     - **Events:** None
                     - **Visibility:** Always visible within the modal
                     - **Components:** None
                 2.1.1.3. **Rounding Increment Dropdown**
                     - **Type:** Dropdown
                     - **Description:** Dropdown to select the rounding increment
                     - **Events:** None
                     - **Visibility:** Always visible within the modal
                     - **Components:** None
                 2.1.1.4. **Direction Dropdown**
                     - **Type:** Dropdown
                     - **Description:** Dropdown to select the direction
                     - **Events:** None
                     - **Visibility:** Always visible within the modal
                     - **Components:** None
                 2.1.1.5. **Save Ratehseet Settings Button**
                     - **Type:** Button
                     - **Description:** Button to save the ratesheet settings
                     - **Events:**
                       - **on-click:** Should close the Ratesheet Settings Modal and save the Ratesheet Settings.
                     - **Visibility:** Always visible within the modal
                     - **Components:** None
                 2.1.1.6. **Cancel Button**
                     - **Type:** Button
                     - **Description:** Button to cancel the modal
                     - **Events:**
                       - **on-click:** Should close the Ratesheet Settings Modal.
                     - **Visibility:** Always visible within the modal
                     - **Components:** None
     2.2. **Effective Date Label**
         - **Type:** Label
         - **Description:** Label to display the effective date
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     2.3. **Former Date Dropdown**
         - **Type:** Dropdown
         - **Description:** Dropdown to select the former date
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     2.4. **Benchmark Label**
         - **Type:** Label
         - **Description:** Label to display the benchmark
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     2.5. **Benchmark Change Label**
         - **Type:** Label
         - **Description:** Label to display the benchmark change
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     2.6. **Last Ratesheet Posted By Label**
         - **Type:** Label
         - **Description:** Label to display the last ratesheet posted by
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None

3. **Audits Container**
   - **Type:** Container
   - **Description:** Container to display the audits
   - **Events:** None
   - **Visibility:** Always visible
   - **Components:**
     3.1. **Exception Tolerance Input**
         - **Type:** Input
         - **Description:** Input to enter the exception tolerance
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     3.2. **Rank 2 Differential Input**
         - **Type:** Input
         - **Description:** Input to enter the rank 2 differential
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     3.3. **Changed Investor Input**
         - **Type:** Input
         - **Description:** Input to enter the changed investor
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     3.4. **Failed Pricing Input**
         - **Type:** Input
         - **Description:** Input to enter the failed pricing
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     3.5. **Inverted Price Input**
         - **Type:** Input
         - **Description:** Input to enter the inverted price
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     3.6. **Lock Period Exception Input**
         - **Type:** Input
         - **Description:** Input to enter the lock period exception
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     3.7. **New Pricing Input**
         - **Type:** Input
         - **Description:** Input to enter the new pricing
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     3.8. **Price Exceptions Input**
         - **Type:** Input
         - **Description:** Input to enter the price exceptions
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     3.9. **No Rank 2 Input**
         - **Type:** Input
         - **Description:** Input to enter the no rank 2
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     3.10. **Rank 2 Differential Input**
         - **Type:** Input
         - **Description:** Input to enter the rank 2 differential
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None
     3.11. **Coupon Change Input**
         - **Type:** Input
         - **Description:** Input to enter the coupon change
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:** None

4. **Ratesheet Conciliation Container**
   - **Type:** Container
   - **Description:** Container to display the ratesheet conciliation
   - **Events:** None
   - **Visibility:** Always visible
   - **Components:**
     4.1. **Ratesheet Conciliation Grid**
         - **Type:** Grid
         - **Description:** Grid to display the ratesheet conciliation
         - **Events:** None
         - **Visibility:** Always visible
         - **Components:**
           4.1.1. **Channel Column**
               - **Type:** Column
               - **Description:** Column to display the channel
               - **Events:** None
               - **Visibility:** Always visible
               - **Components:**
                 4.1.1.1. **Channel Label**
                     - **Type:** Label
                     - **Description:** Label to display the channel
                     - **Events:** None
                     - **Visibility:** Always visible
                     - **Components:** None
           4.1.2. **Product Column**
               - **Type:** Column
               - **Description:** Column to display the product
               - **Events:** None
               - **Visibility:** Always visible
               - **Components:**
                 4.1.2.1. **Product Label**
                     - **Type:** Label
                     - **Description:** Label to display the product
                     - **Events:** None
                     - **Visibility:** Always visible
                     - **Components:** None
           4.1.3. **Rate Column**
               - **Type:** Column
               - **Description:** Column to display the rate
               - **Events:** None
               - **Visibility:** Always visible
               - **Components:**
                 4.1.3.1. **Rate Label**
                     - **Type:** Label
                     - **Description:** Label to display the rate
                     - **Events:** None
                     - **Visibility:** Always visible
                     - **Components:** None
           4.1.4. **15 Column**
               - **Type:** Column
               - **Description:** Column to display the 15-day price
               - **Events:** None
               - **Visibility:** Always visible
               - **Components:**
                 4.1.4.1. **Amount Input**
                     - **Type:** Input
                     - **Description:** Input to enter the amount for the 15-day price
                     - **Events:** None
                     - **Visibility:** Always visible
                     - **Components:** None
                 4.1.4.2. **Loan Details Link**
                     - **Type:** Link
                     - **Description:** Link to navigate to the loan details
                     - **Events:**
                       - **on-click:** Should navigate to the Loan Details Page.
                     - **Visibility:** Always visible
                     - **Components:** None
           4.1.5. **30 Column**
               - **Type:** Column
               - **Description:** Column to display the 30-day price
               - **Events:** None
               - **Visibility:** Always visible
               - **Components:**
                 4.1.5.1. **Amount Input**
                     - **Type:** Input
                     - **Description:** Input to enter the amount for the 30-day price
                     - **Events:** None
                     - **Visibility:** Always visible
                     - **Components:** None
                 4.1.5.2. **Loan Details Link**
                     - **Type:** Link
                     - **Description:** Link to navigate to the loan details
                     - **Events:**
                       - **on-click:** Should navigate to the Loan Details Page.
                     - **Visibility:** Always visible
                     - **Components:** None
           4.1.6. **45 Column**
               - **Type:** Column
               - **Description:** Column to display the 45-day price
               - **Events:** None
               - **Visibility:** Always visible
               - **Components:**
                 4.1.6.1. **Amount Input**
                     - **Type:** Input
                     - **Description:** Input to enter the amount for the 45-day price
                     - **Events:** None
                     - **Visibility:** Always visible
                     - **Components:** None
                 4.1.6.2. **Loan Details Link**
                     - **Type:** Link
                     - **Description:** Link to navigate to the loan details
                     - **Events:**
                       - **on-click:** Should navigate to the Loan Details Page.
                     - **Visibility:** Always visible
                     - **Components:** None
           4.1.7. **60 Column**
               - **Type:** Column
               - **Description:** Column to display the 60-day price
               - **Events:** None
               - **Visibility:** Always visible
               - **Components:**
                 4.1.7.1. **Amount Input**
                     - **Type:** Input
                     - **Description:** Input to enter the amount for the 60-day price
                     - **Events:** None
                     - **Visibility:** Always visible
                     - **Components:** None
                 4.1.7.2. **Loan Details Link**
                     - **Type:** Link
                     - **Description:** Link to navigate to the loan details
                     - **Events:**
                       - **on-click:** Should navigate to the Loan Details Page.
                     - **Visibility:** Always visible
                     - **Components:** None
           4.1.8. **90 Column**
               - **Type:** Column
               - **Description:** Column to display the 90-day price
               - **Events:** None
               - **Visibility:** Always visible
               - **Components:**
                 4.1.8.1. **Amount Input**
                     - **Type:** Input
                     - **Description:** Input to enter the amount for the 90-day price
                     - **Events:** None
                     - **Visibility:** Always visible
                     - **Components:** None
                 4.1.8.2. **Loan Details Link**
                     - **Type:** Link
                     - **Description:** Link to navigate to the loan details
                     - **Events:**
                       - **on-click:** Should navigate to the Loan Details Page.
                     - **Visibility:** Always visible
                     - **Components:** None
           4.1.9. **Investor Column**
               - **Type:** Column
               - **Description:** Column to display the investor
               - **Events:** None
               - **Visibility:** Always visible
               - **Components:**
                 4.1.9.1. **Investor Label**
                     - **Type:** Label
                     - **Description:** Label to display the investor
                     - **Events:** None
                     - **Visibility:** Always visible
                     - **Components:** None

5. **Save For Use Button**
   - **Type:** Button
   - **Description:** Button to save the ratesheet for use
   - **Events:**
     - **on-click:** Should