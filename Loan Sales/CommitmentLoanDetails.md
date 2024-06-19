# Commitment Details Page Documentation

## Components

1. **Commitment Details Container**
   - **Type:** Container
   - **Description:** Container for commitment details.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible.
   - **Components:**
     1. **Commitment ID Input**
        - **Type:** Column
        - **Description:** Input field for Commitment ID.
        - **Events:**
          - **OnChange:** Triggers when the commitment ID is changed.
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     2. **Commitment ID Edit Button**
        - **Type:** Column
        - **Description:** Button to edit Commitment ID.
        - **Events:**
          - **OnClick:** Triggers when the edit button is clicked.
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     3. **Commitment Amount Input**
        - **Type:** Column
        - **Description:** Input field for Commitment Amount.
        - **Events:**
          - **OnChange:** Triggers when the commitment amount is changed.
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     4. **Commitment Amount Edit Button**
        - **Type:** Column
        - **Description:** Button to edit Commitment Amount.
        - **Events:**
          - **OnClick:** Triggers when the edit button is clicked.
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     5. **Expiration Date Input**
        - **Type:** Column
        - **Description:** Input field for Expiration Date.
        - **Events:**
          - **OnChange:** Triggers when the expiration date is changed.
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     6. **Expiration Date Edit Button**
        - **Type:** Column
        - **Description:** Button to edit Expiration Date.
        - **Events:**
          - **OnClick:** Triggers when the edit button is clicked.
        - **Visibility:**
          - Always visible.
        - **Components:**
          None

2. **Loan Details Container**
   - **Type:** Container
   - **Description:** Container for loan details.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible.
   - **Components:**
     1. **Price Label**
        - **Type:** Column
        - **Description:** Label displaying the price.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     2. **Allocated Amount Label**
        - **Type:** Column
        - **Description:** Label displaying the allocated amount.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     3. **Open Trade Amount**
        - **Type:** Column
        - **Description:** Column displaying the open trade amount.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     4. **Paired Out Amount**
        - **Type:** Column
        - **Description:** Column displaying the paired out amount.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     5. **Pair Out Button**
        - **Type:** Column
        - **Description:** Button to pair out amounts.
        - **Events:**
          - **OnClick:** Triggers when the pair out button is clicked.
        - **Visibility:**
          - Always visible.
        - **Components:**
          None

3. **Allocated Tab**
   - **Type:** Tab
   - **Description:** Tab displaying allocated loans.
   - **Events:**
     - **OnSelect:** Triggers when the tab is selected.
   - **Visibility:**
     - Always visible.
   - **Components:**
     1. **Allocated Loans Grid**
        - **Type:** Container
        - **Description:** Container for allocated loans grid.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          1. **Selection**
             - **Type:** Column
             - **Description:** Column for loan selection.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Selection Checkbox**
                  - **Type:** Checkbox
                  - **Description:** Checkbox for selecting loans.
                  - **Events:**
                    - **OnChange:** Triggers when the checkbox state changes.
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          2. **Loan ID**
             - **Type:** Column
             - **Description:** Column displaying the Loan ID.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Loan ID Link**
                  - **Type:** Link
                  - **Description:** Link to loan details.
                  - **Events:**
                    - **OnClick:** Triggers when the loan ID link is clicked.
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          3. **Price**
             - **Type:** Column
             - **Description:** Column displaying the price.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Price Label**
                  - **Type:** Label
                  - **Description:** Label displaying the price.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          4. **Product Code**
             - **Type:** Column
             - **Description:** Column displaying the product code.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Product Code Label**
                  - **Type:** Label
                  - **Description:** Label displaying the product code.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          5. **Note Rate**
             - **Type:** Column
             - **Description:** Column displaying the note rate.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Note Rate Label**
                  - **Type:** Label
                  - **Description:** Label displaying the note rate.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          6. **Amount**
             - **Type:** Column
             - **Description:** Column displaying the amount.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Amount Label**
                  - **Type:** Label
                  - **Description:** Label displaying the amount.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          7. **Allocation Date**
             - **Type:** Column
             - **Description:** Column displaying the allocation date.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Allocation Date Label**
                  - **Type:** Label
                  - **Description:** Label displaying the allocation date.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          8. **Purchase Date**
             - **Type:** Column
             - **Description:** Column displaying the purchase date.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Purchase Date Label**
                  - **Type:** Label
                  - **Description:** Label displaying the purchase date.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None

4. **Available to Allocate Tab**
   - **Type:** Tab
   - **Description:** Tab displaying loans available to allocate.
   - **Events:**
     - **OnSelect:** Triggers when the tab is selected.
   - **Visibility:**
     - Always visible.
   - **Components:**
     1. **Available to Allocate Loans Grid**
        - **Type:** Container
        - **Description:** Container for loans available to allocate grid.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          1. **Selection**
             - **Type:** Column
             - **Description:** Column for loan selection.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Selection Checkbox**
                  - **Type:** Checkbox
                  - **Description:** Checkbox for selecting loans.
                  - **Events:**
                    - **OnChange:** Triggers when the checkbox state changes

.
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          2. **Loan ID**
             - **Type:** Column
             - **Description:** Column displaying the Loan ID.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Loan ID Link**
                  - **Type:** Link
                  - **Description:** Link to loan details.
                  - **Events:**
                    - **OnClick:** Triggers when the loan ID link is clicked.
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          3. **Price**
             - **Type:** Column
             - **Description:** Column displaying the price.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Price Label**
                  - **Type:** Label
                  - **Description:** Label displaying the price.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          4. **Product Code**
             - **Type:** Column
             - **Description:** Column displaying the product code.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Product Code Label**
                  - **Type:** Label
                  - **Description:** Label displaying the product code.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          5. **Note Rate**
             - **Type:** Column
             - **Description:** Column displaying the note rate.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Note Rate Label**
                  - **Type:** Label
                  - **Description:** Label displaying the note rate.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          6. **Amount**
             - **Type:** Column
             - **Description:** Column displaying the amount.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Amount Label**
                  - **Type:** Label
                  - **Description:** Label displaying the amount.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          7. **Allocation Date**
             - **Type:** Column
             - **Description:** Column displaying the allocation date.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Allocation Date Label**
                  - **Type:** Label
                  - **Description:** Label displaying the allocation date.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
          8. **Purchase Date**
             - **Type:** Column
             - **Description:** Column displaying the purchase date.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Purchase Date Label**
                  - **Type:** Label
                  - **Description:** Label displaying the purchase date.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None

5. **Document/Files Tab**
   - **Type:** Tab
   - **Description:** Tab displaying documents and files.
   - **Events:**
     - **OnSelect:** Triggers when the tab is selected.
   - **Visibility:**
     - Always visible.
   - **Components:**
     None