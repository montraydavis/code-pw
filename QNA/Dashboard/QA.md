**General Questions**

  

1. **What is the purpose of the Dashboard Page?**

•  The Dashboard Page provides an overview of key financial metrics and data related to loans, market movements, trades, and investor activities.

  

**API Endpoints**

  

2. **Which API is used to fetch loan sale data?**

•  The APIs used include GET api/queries/dashboard/loansforsale and GET api/queries/dashboard/loansalesrollingthirty.

3. **How do you update the risk position data?**

•  The risk position data is updated using the API POST api/queries/riskposition.

4. **What API is called to get user profile information?**

•  The API GET api/user/profile is called to get user profile information.

5. **Which API is used to fetch recent trades data?**

•  The API GET api/queries/dashboard/recenttrades is used to fetch recent trades data.

6. **How is the status of jobs updated?**

•  The status of jobs is updated using the API POST api/commands/jobs/status.

7. **Which API endpoint provides the configuration settings?**

•  The configuration settings are provided by the API GET api/configuration.

  

**Position Pipeline Container**

  

8. **What happens when you click on the Position Pipeline Link?**

•  Clicking on the Position Pipeline Link navigates to the Hedge Selection Tool Page.

9. **What labels are present in the Position Pipeline Container?**

•  The labels present are the Net Position Amount Label and the Loan Pipeline Amount Label.

10. **What actions are triggered by clicking on the links/buttons in the Position Pipeline Container?**

•  Clicking on the Position Pipeline Link navigates to the Hedge Selection Tool Page.

  

**Market Movement Container**

  

11. **Which labels display market delta values in the Market Movement Container?**

•  The labels are Market Delta - RS Label and Market Delta - Today Label.

  

**Loans Available for Sale Container**

  

12. **What is the function of the Loans Available for Sale Link?**

•  The function of the Loans Available for Sale Link is to navigate to the Request Bids Page.

13. **Which labels indicate the loan amounts in the Loans Available for Sale Container?**

•  The labels are Loans Amount Label and Total UPB Amount Label.

14. **What are the actions triggered by clicking on links in the Loans Available for Sale Container?**

•  Clicking on the Loans Available for Sale Link navigates to the Request Bids Page.

  

**Latest Bid Request Container**

  

15. **What labels are included in the Latest Bid Request Container?**

•  The labels include Bids Received Date Label, Loans with Bids Count Label, and Bids Due Date Label.

16. **Where does the Latest Bid Request Link navigate to?**

•  The Latest Bid Request Link navigates to the Commit Loans Page.

  

**Shock Profile Container**

  

17. **What tabs are available in the Shock Profile Container?**

•  The available tabs are Gain/Loss Tab, Position Tab, and Shock Data Tab.

18. **What is the purpose of the Gain/Loss Tab in the Shock Profile Container?**

•  The Gain/Loss Tab displays the Gain/Loss Chart, which shows the gain or loss over a period.

19. **What data is displayed in the Position Tab of the Shock Profile Container?**

•  The Position Tab shows the Position Chart, which details the positions held.

20. **What information is found in the Shock Data Tab of the Shock Profile Container?**

•  The Shock Data Tab includes the Shock Data Grid, displaying columns such as Rate Shock, Price, Change 32nds, and Unclosed…

21. **What type of chart is displayed under the Gain/Loss Tab in the Shock Profile Container?**

•  The Gain/Loss Chart is displayed under the Gain/Loss Tab.

22. **What type of chart is displayed under the Position Tab in the Shock Profile Container?**

•  The Position Chart is displayed under the Position Tab.

23. **What data is displayed in the Shock Data Tab of the Shock Profile Container?**

•  The Shock Data Grid is displayed under the Shock Data Tab, showing columns such as Rate Shock, Price, Change 32nds, and Unclosed…

24. **What columns are defined in the Shock Data Grid within the Shock Profile Container?**

•  The columns are Rate Shock, Price, Change 32nds, and Unclosed…

  

**Fallout Container**

  

25. **What label displays the fallout amount in the Fallout Container?**

•  The Fallout Amount Label displays the fallout amount.

26. **What type of chart is included in the Fallout Container?**

•  The Fallout Chart is included.

27. **What data source is used for the Fallout Container’s chart?**

•  The data source for the Fallout Chart is not specified, but it likely pulls from one of the defined APIs such as GET api/queries/dashboard/fallout.

  

**Loan Sales Summary Container**

  

28. **What options are available in the Product Type Dropdown in the Loan Sales Summary Container?**

•  The options are Conv30, Conv 15, and Gov 30.

29. **What options are available in the Days Dropdown in the Loan Sales Summary Container?**

•  The options are 30, 60, 90, and 120.

30. **What type of chart is included in the Loan Sales Summary Container?**

•  The Loan Sales Summary Chart is included.

31. **What columns are present in the grid of the Loan Sales Summary Container?**

•  There is no grid specifically mentioned within the Loan Sales Summary Container, but it includes the Loan Sales Summary Chart and dropdowns for filtering data.

32. **What dropdown options filter data in the Loan Sales Summary Container?**

•  The Product Type Dropdown options are Conv30, Conv 15, and Gov 30; the Days Dropdown options are 30, 60, 90, and 120.

  

**Loan Sales (Rolling in 30 Days) Container**

  

33. **What columns are included in the Loan Sales (Rolling in 30 Days) Grid?**

•  The columns are Agency Label, Lender (Conv, Govt), and Cohort (Conv, Govt).

34. **What type of data is displayed in the grid of the Loan Sales (Rolling in 30 Days) Container?**

•  The grid displays data with columns for Agency Label, Lender (Conv, Govt), and Cohort (Conv, Govt).

  

**Top Investors Container**

  

35. **What grids are included in the Top Investors Container?**

•  The grids included are the Top Five Lenders Grid and the Cohort Top Five Investors Grid.

36. **What columns are defined in the Top Five Lenders Grid?**

•  The columns are Investor, Amount (M), and Percent.

37. **What columns are defined in the Cohort Top Five Investors Grid?**

•  The columns are Investor, Amount (M), and Percent.

38. **What are the row definitions for the grids in the Top Investors Container?**

•  Rows in the grids are defined by the column definitions: Investor, Amount (M), and Percent for both the Top Five Lenders Grid and the Cohort Top Five Investors Grid.

  

**Recent Trades Container**

  

39. **Where does the Recent Trades Link navigate to?**

•  The Recent Trades Link navigates to the Trade Management Page.

40. **What columns are included in the Recent Trades Grid?**

•  The columns are Security ID, Buy/Sell, Coupon, Broker/Dealer, Trade Date, Trade Price, and Amount (M).

41. **What API is used as the data source for the Recent Trades Grid?**

•  The data source API is GET api/queries/dashboard/recenttrades.

42. **How does the grid in the Recent Trades Container update?**

•  The grid updates by fetching data from the API GET api/queries/dashboard/recenttrades.

  

**Lock Volume Container**

  

43. **What columns are defined in the Lock Volume Grid?**

•  The columns are Type, Day Over Day, Month to Date, and Last 45 Days.

44. **What API is used as the data source for the Lock Volume Grid?**

•  The data source API is GET api/queries/dashboard/lockvolume.

45. **What columns are defined in the Channel Grid within the Lock Volume Container?**

•  The columns are Channel Status, Locks (M), Change (M), Margin (BPS), and Change (BPS).

46. **What grids are included in the Lock Volume Container?**

•  Grids included are the Lock Volume Grid and the Channel Grid, with data sourced from the API GET api/queries/dashboard/lockvolume.

  

**Market Movement Container**

  

47. **What is the data source for the Market Movement Container?**

•  The data source for the Market Movement Container is not specified in the provided structure, but it may be one of the APIs related to market data.

  

**Fallout Container**

  

48. **What charts and labels are included in the Fallout Container?**

•  The Fallout Container includes the Fallout Amount Label and Fallout Chart.

  

**Recent Trades Container**

  

49. **What columns are defined in the grid of the Recent Trades Container?**

•  Columns are Security ID, Buy/Sell
