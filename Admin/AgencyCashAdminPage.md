# Agency Cash Admin Page Documentation

## Components

1. **FANNIE MAE Tab**
   - **Type:** tab
   - **Description:** Tab for accessing Fannie Mae ratesheet settings.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when Fannie Mae ratesheet settings are available for configuration.
   - **Components:**
      2. **Ratesheet Settings Container**
         - **Type:** container
         - **Description:** Container for setting various parameters related to Fannie Mae ratesheets.
         - **Events:**
           - None
         - **Visibility:**
           - Visible when the FANNIE MAE Tab is active.
         - **Components:**
            3. **Username Input**
               - **Type:** input
               - **Description:** Allows entry of the username for the Fannie Mae seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Ratesheet Settings Container.
               - **Components:**
                 - None
            4. **Password Input**
               - **Type:** input
               - **Description:** Allows entry of the password for the Fannie Mae seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Ratesheet Settings Container.
               - **Components:**
                 - None
            5. **Seller Number Input**
               - **Type:** input
               - **Description:** Allows entry of the seller number for the Fannie Mae seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Ratesheet Settings Container.
               - **Components:**
                 - None
            6. **Remittance Type Dropdown**
               - **Type:** dropdown
               - **Description:** Provides a selection of remittance types for the Fannie Mae seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Ratesheet Settings Container.
               - **Components:**
                 - None
            7. **Delivery Periods Container**
               - **Type:** container
               - **Description:** Contains settings for delivery periods applicable to the Fannie Mae seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Ratesheet Settings Container.
               - **Components:**
                  8. **Delivery Periods List**
                     - **Type:** list
                     - **Description:** Displays the list of delivery periods for the Fannie Mae seller.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the Delivery Periods Container.
                     - **Components:**
                        9. **Delivery Period Days Label**
                           - **Type:** label
                           - **Description:** Shows the number of days for a delivery period.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Visible for each item in the Delivery Periods List.
                           - **Components:**
                             - None
                        10. **Delete Delivery Period Button**
                            - **Type:** button
                            - **Description:** Removes a delivery period from the list.
                            - **Events:**
                              - **on-click:** Should remove the corresponding delivery period from the Delivery Periods List.
                            - **Visibility:**
                              - Visible next to each delivery period item in the Delivery Periods List.
                            - **Components:**
                              - None
                  11. **Add Delivery Period Input**
                     - **Type:** input
                     - **Description:** Allows entry of a new delivery period to be added to the list.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the Delivery Periods Container.
                     - **Components:**
                       - None
                  12. **Add Delivery Period Button**
                      - **Type:** button
                      - **Description:** Adds a new delivery period to the list.
                      - **Events:**
                        - **on-click:** Should add the new delivery period to the Delivery Periods List.
                      - **Visibility:**
                        - Visible when a new delivery period needs to be added.
                      - **Components:**
                        - None
            13. **Save Ratesheet Settings Button**
                - **Type:** button
                - **Description:** Saves all the ratesheet settings entered for the Fannie Mae seller.
                - **Events:**
                  - **on-click:** Should save all the ratesheet settings for the Fannie Mae seller.
                - **Visibility:**
                  - Visible when there are unsaved changes in the Ratesheet Settings Container.
                - **Components:**
                  - None

2. **FANNIE MAE SMP Tab**
   - **Type:** tab
   - **Description:** Tab for accessing Fannie Mae SMP servicing buyer configuration.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when Fannie Mae SMP servicing buyer configuration is available for configuration.
   - **Components:**
      14. **Servicing Buyer Configuration Container**
         - **Type:** container
         - **Description:** Container for configuring servicing buyers for Fannie Mae SMP.
         - **Events:**
           - None
         - **Visibility:**
           - Visible when the FANNIE MAE SMP Tab is active.
         - **Components:**
            15. **Servicing Buyer Configuration Grid**
               - **Type:** grid
               - **Description:** Grid layout for displaying and editing servicing buyer configurations.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Servicing Buyer Configuration Container.
               - **Components:**
                  16. **Servicing Buyer Label**
                     - **Type:** label
                     - **Description:** Label for the servicing buyer column in the configuration grid.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Visible as a header for the servicing buyer column.
                     - **Components:**
                       - None
                  17. **Fannie MAE SMP Servicer ID Input**
                      - **Type:** input
                      - **Description:** Allows entry of the servicer ID for the servicing buyer.
                      - **Events:**
                        - None
                      - **Visibility:**
                        - Visible for each servicing buyer row in the configuration grid.
                      - **Components:**
                        - None
            18. **Save Fannie MAE SMP Button**
                - **Type:** button
                - **Description:** Saves the servicing buyer configuration for Fannie Mae SMP.
                - **Events:**
                  - **on-click:** Should save the servicing buyer configuration for Fannie Mae SMP.
                - **Visibility:**
                  - Visible when there are unsaved changes in the Servicing Buyer Configuration Container.
                - **Components:**
                  - None

3. **FREDDIE MAC RETAINED Tab**
   - **Type:** tab
   - **Description:** Tab for accessing Freddie Mac Retained ratesheet settings.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when Freddie Mac Retained ratesheet settings are available for configuration.
   - **Components:**
      19. **Freddie Mac Retained Ratesheet Settings Container**
         - **Type:** container
         - **Description:** Container for setting various parameters related to Freddie Mac Retained ratesheets.
         - **Events:**
           - None
         - **Visibility:**
           - Visible when the FREDDIE MAC RETAINED Tab is active.
         - **Components:**
            20. **Seller Servicer Number Input**
               - **Type:** input
               - **Description:** Allows entry of the servicer number for the Freddie Mac Retained seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac Retained Ratesheet Settings Container.
               - **Components:**
                 - None
            21. **Servicing Fee Dropdown**
               - **Type:** dropdown
               - **Description:** Provides a selection of servicing fees for the Freddie Mac Retained seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac Retained Ratesheet Settings Container.
               - **Components:**
                 - None
            22. **Master Commitment Number Input**
               - **Type:** input
               - **Description:** Allows entry of the master commitment number for the Freddie Mac Retained seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac Retained Ratesheet Settings Container.
               - **Components:**
                 - None
            23. **Delivery Periods Container**
               - **Type:** container
               - **Description:** Contains settings for delivery periods applicable to the Freddie Mac Retained seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac Retained Ratesheet Settings Container.
               - **Components:**
                  24. **Delivery Periods List**
                     - **Type:** list
                     - **Description:** Displays the list of delivery periods for the Freddie Mac Retained seller.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the Delivery Periods Container.
                     - **Components:**
                        25. **Delivery Period Days Label**
                           - **Type:** label
                           - **Description:** Shows the number of days for a delivery period.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Visible for each item in the Delivery Periods List.
                           - **Components:**
                             - None
                        26. **Delete Delivery Period Button**
                            - **Type:** button
                            - **Description:** Removes a delivery period from the list.
                            - **Events:**
                              - **on-click:** Should remove the corresponding delivery period from the Delivery Periods List.
                            - **Visibility:**
                              - Visible next to each delivery period item in the Delivery Periods List.
                            - **Components:**
                              - None
                  27. **Add Delivery Period Input**
                     - **Type:** input
                     - **Description:** Allows entry of a new delivery period to be added to the list.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the Delivery Periods Container.
                     - **Components:**
                       - None
                  28. **Add Delivery Period Button**
                      - **Type:** button
                      - **Description:** Adds a new delivery period to the list.
                      - **Events:**
                        - **on-click:** Should add the new delivery period to the Delivery Periods List.
                      - **Visibility:**
                        - Visible when a new delivery period needs to be added.
                      - **Components:**
                        - None
            29. **Save Freddie Mac Retained Button**
                - **Type:** button
                - **Description:** Saves all the ratesheet settings entered for the Freddie Mac Retained seller.
                - **Events:**
                  - **on-click:** Should save all the ratesheet settings for the Freddie Mac Retained seller.
                - **Visibility:**
                  - Visible when there are unsaved changes in the Freddie Mac Retained Ratesheet Settings Container.
                - **Components:**
                  - None

4. **FREDDIE MAC RELEASED Tab**
   - **Type:** tab
   - **Description:** Tab for accessing Freddie Mac Released ratesheet settings.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when Freddie Mac Released ratesheet settings are available for configuration.
   - **Components:**
      30. **Freddie Mac Released Ratesheet Settings Container**
         - **Type:** container
         - **Description:** Container for setting various parameters related to Freddie Mac Released ratesheets.
         - **Events:**
           - None
         - **Visibility:**
           - Visible when the FREDDIE MAC RELEASED Tab is active.
         - **Components:**
            31. **Seller Servicer Number Input**
               - **Type:** input
               - **Description:** Allows entry of the servicer number for the Freddie Mac Released seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac Released Ratesheet Settings Container.
               - **Components:**
                 - None
            32. **Servicing Fee Dropdown**
               - **Type:** dropdown
               - **Description:** Provides a selection of servicing fees for the Freddie Mac Released seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac Released Ratesheet Settings Container.
               - **Components:**
                 - None
            33. **Master Commitment Number Input**
               - **Type:** input
               - **Description:** Allows entry of the master commitment number for the Freddie Mac Released seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac Released Ratesheet Settings Container.
               - **Components:**
                 - None
            34. **Escrow / Coverage Dropdown**
               - **Type:** dropdown
               - **Description:** Provides a selection of escrow/coverage options for the Freddie Mac Released seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac Released Ratesheet Settings Container.
               - **Components:**
                 - None
            35. **State Dropdown**
               - **Type:** dropdown
               - **Description:** Provides a selection of states for the Freddie Mac Released seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac Released Ratesheet Settings Container.
               - **Components:**
                 - None
            36. **Loan Amount Input**
               - **Type:** input
               - **Description:** Allows entry of the loan amount for the Freddie Mac Released seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac Released Ratesheet Settings Container.
               - **Components:**
                 - None
            37. **Delivery Periods Container**
               - **Type:** container
               - **Description:** Contains settings for delivery periods applicable to the Freddie Mac Released seller.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac Released Ratesheet Settings Container.
               - **Components:**
                  38. **Delivery Periods List**
                     - **Type:** list
                     - **Description:** Displays the list of delivery periods for the Freddie Mac Released seller.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the Delivery Periods Container.
                     - **Components:**
                        39. **Delivery Period Days Label**
                           - **Type:** label
                           - **Description:** Shows the number of days for a delivery period.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Visible for each item in the Delivery Periods List.
                           - **Components:**
                             - None
                        40. **Delete Delivery Period Button**
                            - **Type:** button
                            - **Description:** Removes a delivery period from the list.
                            - **Events:**
                              - **on-click:** Should remove the corresponding delivery period from the Delivery Periods List.
                            - **Visibility:**
                              - Visible next to each delivery period item in the Delivery Periods List.
                            - **Components:**
                              - None
                  41. **Add Delivery Period Input**
                     - **Type:** input
                     - **Description:** Allows entry of a new delivery period to be added to the list.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the Delivery Periods Container.
                     - **Components:**
                       - None
                  42. **Add Delivery Period Button**
                      - **Type:** button
                      - **Description:** Adds a new delivery period to the list.
                      - **Events:**
                        - **on-click:** Should add the new delivery period to the Delivery Periods List.
                      - **Visibility:**
                        - Visible when a new delivery period needs to be added.
                      - **Components:**
                        - None
            43. **Save Freddie Mac Released Button**
                - **Type:** button
                - **Description:** Saves all the ratesheet settings entered for the Freddie Mac Released seller.
                - **Events:**
                  - **on-click:** Should save all the ratesheet settings for the Freddie Mac Released seller.
                - **Visibility:**
                  - Visible when there are unsaved changes in the Freddie Mac Released Ratesheet Settings Container.
                - **Components:**
                  - None

5. **FREDDIE MAC CTOS Tab**
   - **Type:** tab
   - **Description:** Tab for accessing Freddie Mac CTOS ratesheet settings.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when Freddie Mac CTOS ratesheet settings are available for configuration.
   - **Components:**
      44. **Freddie Mac CTOS Ratesheet Settings Container**
         - **Type:** container
         - **Description:** Container for setting various parameters related to Freddie Mac CTOS ratesheets.
         - **Events:**
           - None
         - **Visibility:**
           - Visible when the FREDDIE MAC CTOS Tab is active.
         - **Components:**
            45. **Servicing Buyer Configuration Container**
               - **Type:** container
               - **Description:** Container for configuring servicing buyers for Freddie Mac CTOS.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the Freddie Mac CTOS Ratesheet Settings Container.
               - **Components:**
                  46. **Servicing Buyer Configuration Grid**
                     - **Type:** grid
                     - **Description:** Grid layout for displaying and editing servicing buyer configurations.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the Servicing Buyer Configuration Container.
                     - **Components:**
                        47. **Servicing Buyer Label**
                           - **Type:** label
                           - **Description:** Label for the servicing buyer column in the configuration grid.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Visible as a header for the servicing buyer column.
                           - **Components:**
                             - None
                        48. **Fannie MAE SMP Servicer ID Input**
                            - **Type:** input
                            - **Description:** Allows entry of the servicer ID for the servicing buyer.
                            - **Events