# Client Management Page Documentation

## Components

1. **Search Clients Input**
   - **Type:** input
   - **Description:** Input to search the clients.
   - **Events:**
     - **on-change:** Should [Fetch Clients]. Should filter [Clients Grid] based on the search input.
   - **Visibility:**
     - Always visible
   - **Components:**
      None

2. **Add New Client Button**
   - **Type:** button
   - **Description:** Button to add a new client.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      2.1. **Add New Client Confirmation Modal**
         - **Type:** modal
         - **Description:** Modal to add a new client.
         - **Events:**
           - None
         - **Visibility:**
           - Visible when [Add New Client Button] is clicked
         - **Components:**
            2.1.1. **Close Button**
               - **Type:** button
               - **Description:** Closes the modal.
               - **Events:**
                 - **on-click:** Closes the modal.
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.2. **Client Name Dropdown**
               - **Type:** dropdown
               - **Description:** Dropdown to select the client name.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.3. **Acronym Input**
               - **Type:** input
               - **Description:** Input to set the client acronym.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.4. **CP Client ID Input**
               - **Type:** input
               - **Description:** Input to set the client CP Client ID.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.5. **Global ID Input**
               - **Type:** input
               - **Description:** Input to set the client Global ID.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.6. **Database Server Input**
               - **Type:** input
               - **Description:** Input to set the database server.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.7. **Database Name Input**
               - **Type:** input
               - **Description:** Input to set the database name.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.8. **Connect To Database Button**
               - **Type:** button
               - **Description:** Button to connect to the database.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.9. **Cancel Button**
               - **Type:** button
               - **Description:** Button to cancel the action.
               - **Events:**
                 - **on-click:** Closes the modal.
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None

3. **Clients Grid**
   - **Type:** grid
   - **Description:** Grid to display the clients.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      3.1. **Column Definitions**
         - **Type:** column-definitions
         - **Description:** Defines the columns of the grid.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the grid
         - **Components:**
            3.1.1. **Client Name**
               - **Type:** column
               - **Description:** Column to display the client name.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the grid
               - **Components:**
                  3.1.1.1. **Client Name Label**
                     - **Type:** label
                     - **Description:** Displays the client name.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the column
                     - **Components:**
                        None
            3.1.2. **Client Type**
               - **Type:** column
               - **Description:** Column to display the client type.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the grid
               - **Components:**
                  3.1.2.1. **Client Type Label**
                     - **Type:** label
                     - **Description:** Displays the client type.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the column
                     - **Components:**
                        None
            3.1.3. **Analyst Assigned**
               - **Type:** column
               - **Description:** Column to display the analyst assigned to the client.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the grid
               - **Components:**
                  3.1.3.1. **Analyst Assigned Label**
                     - **Type:** label
                     - **Description:** Displays the analyst assigned to the client.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the column
                     - **Components:**
                        None
            3.1.4. **Acronym**
               - **Type:** column
               - **Description:** Column to display the client acronym.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the grid
               - **Components:**
                  3.1.4.1. **Acronym Label**
                     - **Type:** label
                     - **Description:** Displays the client acronym.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the column
                     - **Components:**
                        None
            3.1.5. **CP Client ID**
               - **Type:** column
               - **Description:** Column to display the client CP Client ID.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the grid
               - **Components:**
                  3.1.5.1. **CP Client ID Label**
                     - **Type:** label
                     - **Description:** Displays the client CP Client ID.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the column
                     - **Components:**
                        None
            3.1.6. **Global ID**
               - **Type:** column
               - **Description:** Column to display the client Global ID.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the grid
               - **Components:**
                  3.1.6.1. **Global ID Label**
                     - **Type:** label
                     - **Description:** Displays the client Global ID.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the column
                     - **Components:**
                        None
            3.1.7. **Database Server**
               - **Type:** column
               - **Description:** Column to display the database server.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the grid
               - **Components:**
                  3.1.7.1. **Database Server Label**
                     - **Type:** label
                     - **Description:** Displays the database server.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the column
                     - **Components:**
                        None
            3.1.8. **Database Name**
               - **Type:** column
               - **Description:** Column to display the database name.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the grid
               - **Components:**
                  3.1.8.1. **Database Name Label**
                     - **Type:** label
                     - **Description:** Displays the database name.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the column
                     - **Components:**
                        None
            3.1.9. **CP File**
               - **Type:** column
               - **Description:** Column to display the CP file.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the grid
               - **Components:**
                  3.1.9.1. **CP File Label**
                     - **Type:** label
                     - **Description:** Displays the CP file.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the column
                     - **Components:**
                        None
            3.1.10. **Edit**
               - **Type:** column
               - **Description:** Column to display the edit button.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the grid
               - **Components:**
                  3.1.10.1. **Edit Button**
                     - **Type:** button
                     - **Description:** Button to edit the client.
                     - **Events:**
                       - **on-click:** Opens [Edit Client Modal].
                     - **Visibility:**
                       - Always visible within the column
                     - **Components:**
                        3.1.10.1.1. **Edit Client Modal**
                           - **Type:** modal
                           - **Description:** Modal to edit the client.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Visible when [Edit Button] is clicked
                           - **Components:**
                              3.1.10.1.1.1. **Close Button**
                                 - **Type:** button
                                 - **Description:** Closes the modal.
                                 - **Events:**
                                   - **on-click:** Closes the modal.
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.2. **Client Name Input**
                                 - **Type:** input
                                 - **Description:** Input to change the client name.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.3. **Acronym Input**
                                 - **Type:** input
                                 - **Description:** Input to change the client acronym.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.4. **CP Client ID Input**
                                 - **Type:** input
                                 - **Description:** Input to change the client CP Client ID.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.5. **Global ID Input**
                                 - **Type:** input
                                 - **Description:** Input to change the client Global ID.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.6. **Client Type Dropdown**
                                 - **Type:** dropdown
                                 - **Description:** Dropdown to change the client type.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    3.1.10.1.1.6.1. **Options**
                                       - **Type:** options
                                       - **Description:** Options for the client type.
                                       - **Events:**
                                         - None
                                       - **Visibility:**
                                         - Always visible within the dropdown
                                       - **Components:**
                                          3.1.10.1.1.6.1.1. **Full Service**
                                             - **Type:** option
                                             - **Description:** Full Service client type option.
                                             - **Events:**
                                               - None
                                             - **Visibility:**
                                               - Always visible within the options
                                             - **Components:**
                                                None
                                          3.1.10.1.1.6.1.2. **Hybrid-Loan Tables**
                                             - **Type:** option
                                             - **Description:** Hybrid-Loan Tables client type option.
                                             - **Events:**
                                               - None
                                             - **Visibility:**
                                               - Always visible within the options
                                             - **Components:**
                                                None
                                          3.1.10.1.1.6.1.3. **Self Service**
                                             - **Type:** option
                                             - **Description:** Self Service client type option.
                                             - **Events:**
                                               - None
                                             - **Visibility:**
                                               - Always visible within the options
                                             - **Components:**
                                                None
                                          3.1.10.1.1.6.1.4. **Other**
                                             - **Type:** option
                                             - **Description:** Other client type option.
                                             - **Events:**
                                               - None
                                             - **Visibility:**
                                               - Always visible within the options
                                             - **Components:**
                                                None
                              3.1.10.1.1.7. **Database Server Input**
                                 - **Type:** input
                                 - **Description:** Input to change the database server.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.8. **Database Name Input**
                                 - **Type:** input
                                 - **Description:** Input to change the database name.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.9. **Connect To Database Button**
                                 - **Type:** button
                                 - **Description:** Button to connect to the database.
                                 - **Events:**
                                   - **on-click:** Connects to the database. Should [Fetch CP Files].
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.10. **CP File Dropdown**
                                 - **Type:** dropdown
                                 - **Description:** Dropdown to change the CP file.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.11. **Team Assigned Dropdown**
                                 - **Type:** dropdown
                                 - **Description:** Dropdown to change the team assigned to the client.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.12. **Go Live Date Input**
                                 - **Type:** input
                                 - **Description:** Input to change the go live date.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.13. **Save Client Button**
                                 - **Type:** button
                                 - **Description:** Button to save the changes made to the client.
                                 - **Events:**
                                   - **on-click:** Saves the changes made to the client. Closes the modal.
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
                              3.1.10.1.1.14. **Cancel Button**
                                 - **Type:** button
                                 - **Description:** Button to cancel the action.
                                 - **Events:**
                                   - **on-click:** Closes the modal.
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None
            3.1.11. **Users**
               - **Type:** column
               - **Description:** Column to display the users.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the grid
               - **Components:**
                  3.1.11.1. **Users Button**
                     - **Type:** button
                     - **Description:** Button to manage the users.
                     - **Events:**
                       - **on-click:** Opens [User Management Modal].
                     - **Visibility:**
                       - Always visible within the column
                     - **Components:**
                        3.1.11.1.1. **User Management Modal**
                           - **Type:** modal
                           - **Description:** Modal to manage the users.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Visible when [Users Button] is clicked
                           - **Components:**
                              3.1.11.1.1.1. **Close Button**
                                 - **Type:** button
                                 - **Description:** Closes the modal.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the modal
                                 - **Components:**
                                    None