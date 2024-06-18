# Dashboard Page Documentation

## Components

1. **Position Pipeline Container**
   - **Type:** Container
   - **Components:**
     - **Position Pipeline Link**
       - **Type:** Link
       - **Events:**
         - **on-click:** Navigates to Hedge Selection Tool Page.
     - **Net Position Amount Label**
       - **Type:** Label
     - **Loan Pipeline Amount Label**
       - **Type:** Label

2. **Market Movement Container**
   - **Type:** Container
   - **Components:**
     - **Market Delta - RS Label**
       - **Type:** Label
     - **Market Delta - Today Label**
       - **Type:** Label

3. **Loans Available for Sale Container**
   - **Type:** Container
   - **Components:**
     - **Loans Available for Sale Link**
       - **Type:** Link
       - **Events:**
         - **on-click:** Navigates to Request Bids Page.
     - **Loans Amount Label**
       - **Type:** Label
     - **Total UPB Amount Label**
       - **Type:** Label

4. **Latest Bid Request Container**
   - **Type:** Container
   - **Components:**
     - **Bids Received Date Label**
       - **Type:** Label
     - **Loans with Bids Count Label**
       - **Type:** Label
     - **Bids Due Date Label**
       - **Type:** Label
     - **Latest Bid Request Link**
       - **Type:** Link
       - **Events:**
         - **on-click:** Navigates to Commit Loans Page.

5. **Shock Profile Container**
   - **Type:** Container
   - **Components:**
     - **Gain/Loss Tab**
       - **Type:** Tab
       - **Components:**
         - **Gain/Loss Chart**
           - **Type:** Chart
     - **Position Tab**
       - **Type:** Tab
       - **Components:**
         - **Position Chart**
           - **Type:** Chart
     - **Shock Data Tab**
       - **Type:** Tab
       - **Components:**
         - **Shock Data Grid**
           - **Type:** Grid
           - **Column Definitions:**
             - Rate Shock, Price, Change 32nds, Unclosed CP%, Unclosed Hedge Cover%, HW Loan Amount, HW Hedge Amount, Net, DV01 Ratio, DV01wtd MSR, Unclosed Hedge w/ MSRCv%, Net Pipe w/ MSR, Pipe Loan Gain/Loss, Hedge Gain/Loss, MSR Gain/Loss, Consolidated Gain/Loss.

6. **Month to Date Snapshot Container**
   - **Type:** Container
   - **Components:**
     - **Gain/Loss Tab**
       - **Type:** Tab
       - **Components:**
         - **Type Dropdown**
           - **Type:** Dropdown
           - **Options:** BPS, Notional
         - **Gain/Loss Chart**
           - **Type:** Chart
           - **Variants:** Line Chart
     - **Locks/Coverage Tab**
       - **Type:** Tab
       - **Components:**
         - **Locks/Coverage Chart**
           - **Type:** Chart
           - **Variants:** Line and Bar Chart
     - **Base Instrument Tab**
       - **Type:** Tab
       - **Components:**
         - **Base Instrument Chart**
           - **Type:** Chart
           - **Variants:** Line Chart
     - **Position Tab**
       - **Type:** Tab
       - **Components:**
         - **Position Chart**
           - **Type:** Chart
           - **Variants:** Line Chart

7. **Locks Container**
   - **Type:** Container
   - **Components:**
     - **Locks Dropdown**
       - **Type:** Dropdown
       - **Components:**
         - **Close Button**
           - **Type:** Button
           - **Events:**
             - **on-click:** Closes the Locks Dropdown.
       - **Options:** Select All, Conv 30, Conv 15, Gov 30, Other
     - **Locks Chart**
       - **Type:** Chart

8. **Fallout Container**
   - **Type:** Container
   - **Components:**
     - **Fallout Amount Label**
       - **Type:** Label
     - **Fallout Chart**
       - **Type:** Chart

9. **Loan Sales Summary Container**
   - **Type:** Container
   - **Components:**
     - **Product Type Dropdown**
       - **Type:** Dropdown
       - **Options:** Conv30, Conv 15, Gov 30
     - **Days Dropdown**
       - **Type:** Dropdown
       - **Options:** 30, 60, 90, 120
     - **Loan Sales Summary Chart**
       - **Type:** Chart

10. **Loan Sales (Rolling in 30 Days) Container**
    - **Type:** Container
    - **Components:**
      - **Loan Sales (Rolling in 30 Days) Grid**
        - **Type:** Grid
        - **Column Definitions:** Agency Label, Lender (with sub-columns Conv and Govt), Cohort (with sub-columns Conv and Govt).

11. **Top Investors Container**
    - **Type:** Container
    - **Components:**
      - **Top Five Lenders Grid**
        - **Type:** Grid
        - **Column Definitions:** Investor, Amount (M), Percent.
      - **Cohort Top Five Investors Grid**
        - **Type:** Grid
        - **Column Definitions:** Investor, Amount (M), Percent.

12. **Recent Trades Container**
    - **Type:** Container
    - **Components:**
      - **Recent Trades Link**
        - **Type:** Link
        - **Events:**
          - **on-click:** Navigates to Trade Management Page.
      - **Recent Trades Grid**
        - **Type:** Grid
        - **Column Definitions:** Security ID, Buy/Sell, Coupon, Broker/Dealer, Trade Date, Trade Price, Amount (M).

13. **Lock Volume Container**
    - **Type:** Container
    - **Components:**
      - **Lock Volume Grid**
        - **Type:** Grid
        - **Column Definitions:** Type, Day Over Day, Month to Date, Last 45 Days.
      - **Channel Grid**
        - **Type:** Grid
        - **Column Definitions:** Channel Status, Locks (M), Change (M), Margin (BPS), Change (BPS).