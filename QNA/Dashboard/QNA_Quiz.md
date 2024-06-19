**General Questions**

  

1. **What is the purpose of the Dashboard Page?**

•  **Incorrect Answer:** The Dashboard Page is used for logging in to the system.

•  **Correct Answer:** The Dashboard Page provides an overview of key financial metrics and data related to loans, market movements, trades, and investor activities.

  

**API Endpoints**

  

2. **Which API is used to fetch loan sale data?**

•  **Incorrect Answer:** POST api/queries/dashboard/loansforsale

•  **Correct Answer:** The APIs used include GET api/queries/dashboard/loansforsale and GET api/queries/dashboard/loansalesrollingthirty.

3. **How do you update the risk position data?**

•  **Incorrect Answer:** Using GET api/queries/riskposition

•  **Correct Answer:** The risk position data is updated using the API POST api/queries/riskposition.

4. **What API is called to get user profile information?**

•  **Incorrect Answer:** POST api/user/profile

•  **Correct Answer:** The API GET api/user/profile is called to get user profile information.

5. **Which API is used to fetch recent trades data?**

•  **Incorrect Answer:** POST api/queries/dashboard/recenttrades

•  **Correct Answer:** The API GET api/queries/dashboard/recenttrades is used to fetch recent trades data.

6. **How is the status of jobs updated?**

•  **Incorrect Answer:** Using GET api/commands/jobs/status

•  **Correct Answer:** The status of jobs is updated using the API POST api/commands/jobs/status.

7. **Which API endpoint provides the configuration settings?**

•  **Incorrect Answer:** POST api/configuration

•  **Correct Answer:** The configuration settings are provided by the API GET api/configuration.

  

**Position Pipeline Container**

  

8. **What happens when you click on the Position Pipeline Link?**

•  **Incorrect Answer:** It logs the user out.

•  **Correct Answer:** Clicking on the Position Pipeline Link navigates to the Hedge Selection Tool Page.

9. **What labels are present in the Position Pipeline Container?**

•  **Incorrect Answer:** Username Label and Password Label

•  **Correct Answer:** The labels present are the Net Position Amount Label and the Loan Pipeline Amount Label.

10. **What actions are triggered by clicking on the links/buttons in the Position Pipeline Container?**

•  **Incorrect Answer:** It refreshes the page.

•  **Correct Answer:** Clicking on the Position Pipeline Link navigates to the Hedge Selection Tool Page.

  

**Market Movement Container**

  

11. **Which labels display market delta values in the Market Movement Container?**

•  **Incorrect Answer:** Total Delta Label and Average Delta Label

•  **Correct Answer:** The labels are Market Delta - RS Label and Market Delta - Today Label.

  

**Loans Available for Sale Container**

  

12. **What is the function of the Loans Available for Sale Link?**

•  **Incorrect Answer:** To navigate to the Home Page

•  **Correct Answer:** The function of the Loans Available for Sale Link is to navigate to the Request Bids Page.

13. **Which labels indicate the loan amounts in the Loans Available for Sale Container?**

•  **Incorrect Answer:** Loan Type Label and Interest Rate Label

•  **Correct Answer:** The labels are Loans Amount Label and Total UPB Amount Label.

14. **What are the actions triggered by clicking on links in the Loans Available for Sale Container?**

•  **Incorrect Answer:** It saves the current settings.

•  **Correct Answer:** Clicking on the Loans Available for Sale Link navigates to the Request Bids Page.

  

**Latest Bid Request Container**

  

15. **What labels are included in the Latest Bid Request Container?**

•  **Incorrect Answer:** Bidder Name Label and Bid Amount Label

•  **Correct Answer:** The labels include Bids Received Date Label, Loans with Bids Count Label, and Bids Due Date Label.

16. **Where does the Latest Bid Request Link navigate to?**

•  **Incorrect Answer:** To the Login Page

•  **Correct Answer:** The Latest Bid Request Link navigates to the Commit Loans Page.

  

**Shock Profile Container**

  

17. **What tabs are available in the Shock Profile Container?**

•  **Incorrect Answer:** Summary Tab, Details Tab, and Data Tab

•  **Correct Answer:** The available tabs are Gain/Loss Tab, Position Tab, and Shock Data Tab.

18. **What is the purpose of the Gain/Loss Tab in the Shock Profile Container?**

•  **Incorrect Answer:** To display the total profit only.

•  **Correct Answer:** The Gain/Loss Tab displays the Gain/Loss Chart, which shows the gain or loss over a period.

19. **What data is displayed in the Position Tab of the Shock Profile Container?**

•  **Incorrect Answer:** Only the total positions

•  **Correct Answer:** The Position Tab shows the Position Chart, which details the positions held.

20. **What information is found in the Shock Data Tab of the Shock Profile Container?**

•  **Incorrect Answer:** Historical shock data only.

•  **Correct Answer:** The Shock Data Tab includes the Shock Data Grid, displaying columns such as Rate Shock, Price, Change 32nds, and Unclosed…

21. **What type of chart is displayed under the Gain/Loss Tab in the Shock Profile Container?**

•  **Incorrect Answer:** Pie Chart

•  **Correct Answer:** The Gain/Loss Chart is displayed under the Gain/Loss Tab.

22. **What type of chart is displayed under the Position Tab in the Shock Profile Container?**

•  **Incorrect Answer:** Line Chart

•  **Correct Answer:** The Position Chart is displayed under the Position Tab.

23. **What data is displayed in the Shock Data Tab of the Shock Profile Container?**

•  **Incorrect Answer:** General market data

•  **Correct Answer:** The Shock Data Grid is displayed under the Shock Data Tab, showing columns such as Rate Shock, Price, Change 32nds, and Unclosed…

24. **What columns are defined in the Shock Data Grid within the Shock Profile Container?**

•  **Incorrect Answer:** Only the Price and Rate Shock columns

•  **Correct Answer:** The columns are Rate Shock, Price, Change 32nds, and Unclosed…

  

**Fallout Container**

  

25. **What label displays the fallout amount in the Fallout Container?**

•  **Incorrect Answer:** Total Amount Label

•  **Correct Answer:** The Fallout Amount Label displays the fallout amount.

26. **What type of chart is included in the Fallout Container?**

•  **Incorrect Answer:** Pie Chart

•  **Correct Answer:** The Fallout Chart is included.

27. **What data source is used for the Fallout Container’s chart?**

•  **Incorrect Answer:** Local static data

•  **Correct Answer:** The data source for the Fallout Chart is not specified, but it likely pulls from one of the defined APIs such as GET api/queries/dashboard/fallout.

  

**Loan Sales Summary Container**

  

28. **What options are available in the Product Type Dropdown in the Loan Sales Summary Container?**

•  **Incorrect Answer:** Fixed, Adjustable, and Hybrid

•  **Correct Answer:** The options are Conv30, Conv 15, and Gov 30.

29. **What options are available in the Days Dropdown in the Loan Sales Summary Container?**

•  **Incorrect Answer:** 7, 14, 21, 28

•  **Correct Answer:** The options are 30, 60, 90, and 120.

30. **What type of chart is included in the Loan Sales Summary Container?**

•  **Incorrect Answer:** Line Chart

•  **Correct Answer:** The Loan Sales Summary Chart is included.

31. **What columns are present in the grid of the Loan Sales Summary Container?**

•  **Incorrect Answer:** Loan Type and Interest Rate

•  **Correct Answer:** There is no grid specifically mentioned within the Loan Sales Summary Container, but it includes the Loan Sales Summary Chart and dropdowns for filtering data.

32. **What dropdown options filter data in the Loan Sales Summary Container?**

•  **Incorrect Answer:** Loan Type and Status

•  **Correct Answer:** The Product Type Dropdown options are Conv30, Conv 15, and Gov 30; the Days Dropdown options are 30, 60, 90, and 120.

  

**Loan Sales (Rolling in 30 Days) Container**

  

33. **What columns are included in the Loan Sales (Rolling in 30 Days) Grid?**

•  **Incorrect Answer:** Loan Type, Amount, and Interest Rate

•  **Correct Answer:** The columns are Agency Label, Lender (Conv, Govt), and Cohort (Conv, Govt).

34. **What type of data is displayed in the grid of the Loan Sales (Rolling in 30 Days) Container?**

•  **Incorrect Answer:** Monthly Sales Data

•  **Correct Answer:** The grid displays data with columns for Agency Label, Lender (Conv, Govt), and Cohort (Conv, Govt).

  

**Top Investors Container**

  

35. **What grids are included in the Top Investors Container?**

•  **Incorrect Answer:** All Investors Grid and Top Ten Lenders Grid

•  **Correct Answer:** The grids included are the Top Five Lenders Grid and the Cohort Top Five Investors Grid.

36. **What columns are defined in the Top Five Lenders Grid?**

•  **Incorrect Answer:** Investor Name, Loan Amount, and Interest Rate

•  **Correct Answer:** The columns are Investor, Amount (M), and Percent.

37. **What columns are defined in the Cohort Top Five Investors Grid?**

•  **Incorrect Answer:** Investor Name, Loan
