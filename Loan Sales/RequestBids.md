# Bid Request Page Documentation

## Components

1. **API Collection**
   - **Type:** API Collection
   - **Description:** Collection of API endpoints for bid request operations.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible.
   - **Components:**
     1. **POST api/commands/commit-loans/has-bid-requested-on-loans**
        - **Type:** API Endpoint
        - **Description:** Endpoint to check if a bid has been requested on loans.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     2. **POST api/commands/jobs/status**
        - **Type:** API Endpoint
        - **Description:** Endpoint to get the status of a job.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     3. **POST api/commands/requestBid/create**
        - **Type:** API Endpoint
        - **Description:** Endpoint to create a bid request.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     4. **POST api/queries/requestBid/details**
        - **Type:** API Endpoint
        - **Description:** Endpoint to get details of a bid request.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     5. **GET api/queries/loanfilters**
        - **Type:** API Endpoint
        - **Description:** Endpoint to get loan filters.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     6. **GET api/queries/data-alerts**
        - **Type:** API Endpoint
        - **Description:** Endpoint to get data alerts.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None

2. **Loans Available For Sale Container**
   - **Type:** Container
   - **Description:** Container to display the loans available for sale.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible.
   - **Components:**
     1. **Included Loans Label**
        - **Type:** Label
        - **Description:** Label to display the number of loans included in the bid request.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     2. **Time Due Label**
        - **Type:** Label
        - **Description:** Label to display the time due for the bid request.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     3. **Delivery Days Label**
        - **Type:** Label
        - **Description:** Label to display the number of days until delivery.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     4. **Investors Label**
        - **Type:** Label
        - **Description:** Label to display the number of investors who have been offered to bid on the sale.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     5. **Total UPB Label**
        - **Type:** Label
        - **Description:** Label to display the total UPB of the loans included in the sale.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     6. **Conventional UPB Label**
        - **Type:** Label
        - **Description:** Label to display the total UPB of the conventional loans included in the sale.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     7. **Government UPB Label**
        - **Type:** Label
        - **Description:** Label to display the total UPB of the government loans included in the sale.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     8. **Request Bids Button**
        - **Type:** Button
        - **Description:** Button to request bids on the sale.
        - **Events:**
          - **OnClick:** Opens the Request Bids Confirmation Modal.
        - **Visibility:**
          - Always visible.
        - **Components:**
          1. **Request Bids Confirmation Modal**
             - **Type:** Modal
             - **Description:** Modal to confirm the request bids.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Close Button**
                  - **Type:** Button
                  - **Description:** Button to close the modal.
                  - **Events:**
                    - **OnClick:** Closes the modal.
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
               2. **Request Bids Confirmation Label**
                  - **Type:** Label
                  - **Description:** Label to confirm the request bids.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
               3. **Request Bids Button**
                  - **Type:** Button
                  - **Description:** Button to request bids on the sale.
                  - **Events:**
                    - **OnClick:** 
                      - Executes POST api/commands/commit-loans/has-bid-requested-on-loans.
                      - Checks for duplicate request name and shows Duplicate Request Name Modal if found.
                      - Checks if loans include already offered loans and shows Already Offered Loans Modal if found.
                      - Executes POST api/commands/requestBid/create.
                      - Submits the bid request.
                      - Closes the modal.
                      - Resets all components of the Loans Available For Sale Container.
                      - Resets Included Loans Grid.
                      - Resets Excluded Loans Grid.
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
               4. **Duplicate Request Name Modal**
                  - **Type:** Modal
                  - **Description:** Modal to confirm the duplicate request name.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Visible if duplicate request name is found.
                  - **Components:**
                    1. **Duplicate Request Name Label**
                       - **Type:** Label
                       - **Description:** Label to confirm the duplicate request name.
                       - **Events:**
                         - None
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
                    2. **Close Button**
                       - **Type:** Button
                       - **Description:** Button to close the modal.
                       - **Events:**
                         - **OnClick:** Closes the modal.
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
               5. **Already Offered Loans Modal**
                  - **Type:** Modal
                  - **Description:** Modal to confirm the already offered loans.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Visible if loans include already offered loans.
                  - **Components:**
                    1. **Already Offered Loans Label**
                       - **Type:** Label
                       - **Description:** Label to confirm the already offered loans.
                       - **Events:**
                         - None
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
                    2. **Close Button**
                       - **Type:** Button
                       - **Description:** Button to close the modal.
                       - **Events:**
                         - **OnClick:** Closes the modal.
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
                    3. **Confirm Button**
                       - **Type:** Button
                       - **Description:** Button to confirm the already offered loans.
                       - **Events:**
                         - **OnClick:** Continues with the bid request.
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
                    4. **Cancel Button**
                       - **Type:** Button
                       - **Description:** Button to cancel the request bids.
                       - **Events:**
                         - **OnClick:** Cancels the bid request and returns to the previous state.
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None

3. **Request Details Container**
   - **Type:** Container
   - **Description:** Container to display the details of the bid request.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible.
   - **Components:**
     1. **Show Request Details Link**
        - **Type:** Link
        - **Description:** Link to show the details of the bid request.
        - **Events:**
          - **OnClick:** Shows the Details Container, hides the Hide Request Details Link, and shows the Show Request Details Link.
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     2

. **Hide Request Details Link**
        - **Type:** Link
        - **Description:** Link to hide the details of the bid request.
        - **Events:**
          - **OnClick:** Hides the Details Container, shows the Show Request Details Link, and hides the Hide Request Details Link.
        - **Visibility:**
          - Always visible.
        - **Components:**
          None
     3. **Details Container**
        - **Type:** Container
        - **Description:** Container to display the details of the bid request.
        - **Events:**
          - None
        - **Visibility:**
          - Visible when Show Request Details Link is clicked.
        - **Components:**
          1. **Request Name Input**
             - **Type:** Input
             - **Description:** Input to enter the name of the bid request.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               None
          2. **Bids Due Date Input**
             - **Type:** Input
             - **Description:** Input to enter the due date of the bids.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               None
          3. **Comments Input**
             - **Type:** Input
             - **Description:** Input to enter the comments for the bid request.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               None
          4. **Included Bulk Investors Container**
             - **Type:** Container
             - **Description:** Container to display the included bulk investors.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Search Included Bulk Investors Input**
                  - **Type:** Input
                  - **Description:** Input to search the included bulk investors.
                  - **Events:**
                    - **OnChange:** Updates the Included Bulk Investors List to include investors whose names contain the search string.
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
               2. **Include/Exclude All Investors Dropdown**
                  - **Type:** Dropdown
                  - **Description:** Dropdown to include or exclude all investors.
                  - **Events:**
                    - **OnClick:** Includes or excludes all investors based on the selected option.
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    1. **All**
                       - **Type:** Option
                       - **Description:** Option to include all investors.
                       - **Events:**
                         - **OnClick:** Includes all investors.
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
                    2. **None**
                       - **Type:** Option
                       - **Description:** Option to exclude all investors.
                       - **Events:**
                         - **OnClick:** Excludes all investors.
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
               3. **Global Days Input**
                  - **Type:** Input
                  - **Description:** Input to enter the global days.
                  - **Events:**
                    - **OnChange:** Updates the Days Input of each Bulk Investors Client List row to the value of the Global Days Input.
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    None
               4. **Bulk Investors Client List**
                  - **Type:** Container
                  - **Description:** Container to display the list of bulk investors.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    1. **Include/Exclude Investor Checkbox**
                       - **Type:** Checkbox
                       - **Description:** Checkbox to include or exclude an investor.
                       - **Events:**
                         - **OnChecked:** Includes the investor.
                         - **OnUnchecked:** Excludes the investor.
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
                    2. **Investor Name Label**
                       - **Type:** Text
                       - **Description:** Label to display the name of the investor.
                       - **Events:**
                         - None
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
                    3. **Days Input**
                       - **Type:** Input
                       - **Description:** Input to enter the days.
                       - **Events:**
                         - None
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
          5. **Non-Bulk Investors Container**
             - **Type:** Container
             - **Description:** Container to display the non-bulk investors.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Non-Bulk Best Efforts List**
                  - **Type:** Container
                  - **Description:** Container to display the list of non-bulk best efforts investors.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    1. **Investor Name Label**
                       - **Type:** Label
                       - **Description:** Label to display the name of the investor.
                       - **Events:**
                         - None
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
               2. **Non-Bulk Cash List**
                  - **Type:** Container
                  - **Description:** Container to display the list of non-bulk cash investors.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    1. **Investor Name Label**
                       - **Type:** Label
                       - **Description:** Label to display the name of the investor.
                       - **Events:**
                         - None
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None
               3. **Non-Bulk MBS List**
                  - **Type:** Container
                  - **Description:** Container to display the list of non-bulk MBS investors.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    1. **Investor Name Label**
                       - **Type:** Label
                       - **Description:** Label to display the name of the investor.
                       - **Events:**
                         - None
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         None

4. **Loan Details Expander**
   - **Type:** Expander
   - **Description:** Expander to display the loan details.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible.
   - **Components:**
     1. **Filters Container**
        - **Type:** Container
        - **Description:** Container to display the filters.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          1. **Loan Type Dropdown**
             - **Type:** Dropdown
             - **Description:** Dropdown to filter by loan type.
             - **Events:**
               - **OnChange:** Removes all loans which do not meet the Loan Type filter criteria.
             - **Visibility:**
               - Always visible.
             - **Components:**
               None
          2. **Loan Purpose Dropdown**
             - **Type:** Dropdown
             - **Description:** Dropdown to filter by loan purpose.
             - **Events:**
               - **OnChange:** Removes all loans which do not meet the Loan Purpose filter criteria.
             - **Visibility:**
               - Always visible.
             - **Components:**
               None
          3. **Loan Limit Type Dropdown**
             - **Type:** Dropdown
             - **Description:** Dropdown to filter by loan limit type.
             - **Events:**
               - **OnChange:** Removes all loans which do not meet the Loan Limit Type filter criteria.
             - **Visibility:**
               - Always visible.
             - **Components:**
               None
          4. **Occupancy Dropdown**
             - **Type:** Dropdown
             - **Description:** Dropdown to filter by occupancy.
             - **Events:**
               - **OnChange:** Removes all loans which do not meet the Occupancy filter criteria.
             - **Visibility:**
               - Always visible.
             - **Components:**
               None
          5. **Rate Type Dropdown**
             - **Type:** Dropdown
             - **Description:** Dropdown to filter by rate type.
             - **Events:**
               - **OnChange:** Removes all loans which do not meet the Rate Type filter criteria.
             - **Visibility:**
               - Always visible.
             - **Components:**
               None
          6. **Min Ammort Term Input**
             - **Type:** Input
             - **Description:** Input to filter by minimum amortization term.
             - **Events:**
               - **OnChange:** Removes all loans which do not meet the Min Ammort Term filter criteria.
             - **Visibility:**
               - Always visible.
             - **Components:**
               None
          7. **Max Ammort Term Input**
             - **Type:** Input
             - **Description:** Input to filter by maximum amortization term.
             - **Events:**
               - **OnChange:** Removes all loans which do not meet the Max Ammort Term filter criteria.
             - **Visibility:**
               - Always visible.
            

 - **Components:**
               None
          8. **Included Offered Loans Toggle**
             - **Type:** Checkbox
             - **Description:** Checkbox to include offered loans.
             - **Events:**
               - **OnChange:** Removes all loans which do not meet the Included Offered Loans filter criteria.
             - **Visibility:**
               - Always visible.
             - **Components:**
               None
     2. **Loans Container**
        - **Type:** Container
        - **Description:** Container to display the loans.
        - **Events:**
          - None
        - **Visibility:**
          - Always visible.
        - **Components:**
          1. **Included Loans Tab**
             - **Type:** Tab
             - **Description:** Tab to display the included loans.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Included Loans Grid**
                  - **Type:** Grid
                  - **Description:** Grid to display the included loans.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    1. **Include**
                       - **Type:** Column
                       - **Description:** Column to include a loan in the bid request.
                       - **Events:**
                         - None
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         1. **Include Loan Button**
                            - **Type:** Button
                            - **Description:** Button to include a loan in the bid request.
                            - **Events:**
                              - **OnClick:** 
                                - Adds +1 loan to bid request.
                                - Updates Included Loans Label.
                                - Updates Total UPB Label.
                                - Updates Conventional UPB Label.
                                - Updates Government UPB Label.
                            - **Visibility:**
                              - Always visible.
                            - **Components:**
                              None
          2. **Excluded Loans Tab**
             - **Type:** Tab
             - **Description:** Tab to display the excluded loans.
             - **Events:**
               - None
             - **Visibility:**
               - Always visible.
             - **Components:**
               1. **Excluded Loans Grid**
                  - **Type:** Grid
                  - **Description:** Grid to display the excluded loans.
                  - **Events:**
                    - None
                  - **Visibility:**
                    - Always visible.
                  - **Components:**
                    1. **Exclude**
                       - **Type:** Column
                       - **Description:** Column to exclude a loan from the bid request.
                       - **Events:**
                         - None
                       - **Visibility:**
                         - Always visible.
                       - **Components:**
                         1. **Exclude Loan Button**
                            - **Type:** Button
                            - **Description:** Button to exclude a loan from the bid request.
                            - **Events:**
                              - **OnClick:** 
                                - If loans included > 0, enables Request Bids Button.
                                - If no loans included, disables Request Bids Button.
                                - Removes -1 loan from bid request.
                                - Updates Included Loans Label.
                                - Updates Total UPB Label.
                                - Updates Conventional UPB Label.
                                - Updates Government UPB Label.
                            - **Visibility:**
                              - Always visible.
                            - **Components:**
                              None