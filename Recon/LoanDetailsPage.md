# Loan Details Page Documentation

## Components

1. **Loan Details Container**
   - **Type:** Container
   - **Description:** Contains all the loan detail labels.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      1. **Product Code Label**
         - **Type:** Label
         - **Description:** Displays the product code of the loan.
      2. **Channel Label**
         - **Type:** Label
         - **Description:** Displays the channel of the loan.
      3. **Loan Amount Label**
         - **Type:** Label
         - **Description:** Displays the amount of the loan.
      4. **Property Occupancy Label**
         - **Type:** Label
         - **Description:** Displays the occupancy status of the property.
      5. **Note Rate Percent Label**
         - **Type:** Label
         - **Description:** Displays the note rate percentage of the loan.
      6. **Property Type Label**
         - **Type:** Label
         - **Description:** Displays the type of property.
      7. **Loan Purpose Label**
         - **Type:** Label
         - **Description:** Displays the purpose of the loan.
      8. **Property Units Label**
         - **Type:** Label
         - **Description:** Displays the number of units in the property.
      9. **Current Stage Label**
         - **Type:** Label
         - **Description:** Displays the current stage of the loan.
      10. **Property State Label**
          - **Type:** Label
          - **Description:** Displays the state where the property is located.
      11. **FICO Score Label**
          - **Type:** Label
          - **Description:** Displays the FICO score associated with the loan.
      12. **Refinance Type Label**
          - **Type:** Label
          - **Description:** Displays the type of refinance.
      13. **LTV Ratio Label**
          - **Type:** Label
          - **Description:** Displays the loan-to-value ratio.
      14. **Loan Status Label**
          - **Type:** Label
          - **Description:** Displays the current status of the loan.
      15. **CLTV Ratio Label**
          - **Type:** Label
          - **Description:** Displays the combined loan-to-value ratio.

2. **Supplement Data Container**
   - **Type:** Container
   - **Description:** Contains additional data labels related to the loan.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      1. **Lock Date Label**
         - **Type:** Label
         - **Description:** Displays the date the loan rate was locked.
      2. **Lender Acquisition Cost Label**
         - **Type:** Label
         - **Description:** Displays the acquisition cost for the lender.
      3. **Lock Expiration Date Label**
         - **Type:** Label
         - **Description:** Displays the expiration date of the loan rate lock.
      4. **Lender Profit Margin Label**
         - **Type:** Label
         - **Description:** Displays the profit margin for the lender.
      5. **Estimated Fund Date Label**
         - **Type:** Label
         - **Description:** Displays the estimated date for the loan funding.
      6. **Secondary Cost Label**
         - **Type:** Label
         - **Description:** Displays the secondary cost associated with the loan.
      7. **Loan Funded Date Label**
         - **Type:** Label
         - **Description:** Displays the date the loan was funded.
      8. **Allocation Date Label**
         - **Type:** Label
         - **Description:** Displays the date the loan was allocated.
      9. **Purchased Date Label**
         - **Type:** Label
         - **Description:** Displays the date the loan was purchased.
      10. **Shipped to Investor Date Label**
          - **Type:** Label
          - **Description:** Displays the date the loan was shipped to the investor.
      11. **Pool/Commitment Number Label**
          - **Type:** Label
          - **Description:** Displays the pool or commitment number associated with the loan.

3. **Pricing Details Tab**
   - **Type:** Tab
   - **Description:** Tab containing the pricing details of the loan.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when selected
   - **Components:**
      1. **Best Executions Ranking Container**
         - **Type:** Container
         - **Description:** Contains the grid showing best execution rankings.
         - **Components:**
            1. **Best Executions Grid**
               - **Type:** Grid
               - **Description:** Displays the best execution rankings.
               - **Components:**
                  - **Rank Column**
                    - **Type:** Column
                    - **Description:** Displays the rank in best execution.
                  - **Price Column**
                    - **Type:** Column
                    - **Description:** Displays the price for the rank.
                  - **Spread to BestEx Column**
                    - **Type:** Column
                    - **Description:** Displays the spread to the best execution.
                  - **Execution Column**
                    - **Type:** Column
                    - **Description:** Displays the type of execution.
                  - **Coupon Column**
                    - **Type:** Column
                    - **Description:** Displays the coupon for the execution.
      2. **Best Execution Detail Container**
         - **Type:** Container
         - **Description:** Contains detailed information about the best execution.
         - **Components:**
            - None
      3. **BUYUP/BUYDOWN Container**
         - **Type:** Container
         - **Description:** Contains information about buy-up and buy-down options.
         - **Components:**
            - None

4. **Status Tab**
   - **Type:** Tab
   - **Description:** Tab displaying the current status of the loan.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when selected
   - **Components:**
      - None

5. **Coverage Tab**
   - **Type:** Tab
   - **Description:** Tab displaying coverage information related to the loan.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when selected
   - **Components:**
      - None

6. **Shocks Tab**
   - **Type:** Tab
   - **Description:** Tab displaying potential shocks that could affect the loan.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when selected
   - **Components:**
      - None

7. **Unpriced Investors Tab**
   - **Type:** Tab
   - **Description:** Tab displaying information about investors interested in the loan that have not been priced.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when selected
   - **Components:**
      - None

8. **Margin Details Tab**
   - **Type:** Tab
   - **Description:** Tab displaying details about the margins associated with the loan.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when selected
   - **Components:**
      - None