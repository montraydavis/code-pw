# Group Management Page Documentation

## Components

1. **Search Groups Input**
   - **Type:** input
   - **Description:** Input to search the groups.
   - **Events:**
     - **on-change:** Should [Fetch Groups]. Should filter [Groups Grid] based on the search input.
   - **Visibility:**
     - Always visible
   - **Components:**
      None

2. **Create New Group Button**
   - **Type:** button
   - **Description:** Button to trigger the creation of a new Group.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      2.1. **Create New Group Confirmation Modal**
         - **Type:** modal
         - **Description:** Modal to create a new Group.
         - **Events:**
           - None
         - **Visibility:**
           - Visible when [Create New Group Button] is clicked
         - **Components:**
            2.1.1. **Close Button**
               - **Type:** button
               - **Description:** Closes the modal.
               - **Events:**
                 - **on-click:** Closes [Create New Group Confirmation Modal].
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.2. **Group Name Dropdown**
               - **Type:** dropdown
               - **Description:** Dropdown to select the Group name.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.3. **Acronym Input**
               - **Type:** input
               - **Description:** Input to set the Group acronym.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.4. **CP Group ID Input**
               - **Type:** input
               - **Description:** Input to set the Group CP Group ID.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None
            2.1.5. **Global ID Input**
               - **Type:** input
               - **Description:** Input to set the Group Global ID.
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
               - **Description:** Closes the modal.
               - **Events:**
                 - **on-click:** Closes [Create New Group Confirmation Modal].
               - **Visibility:**
                 - Always visible within the modal
               - **Components:**
                  None

3. **Groups Grid**
   - **Type:** grid
   - **Description:** Grid to display the Groups.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      3.1. **Group Name Column**
         - **Type:** column
         - **Description:** Column to display the Group name.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the grid
         - **Components:**
            3.1.1. **Group Name Label**
               - **Type:** label
               - **Description:** Displays the Group name.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the column
               - **Components:**
                  None
      3.2. **Group Type Column**
         - **Type:** column
         - **Description:** Column to display the Group type.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the grid
         - **Components:**
            3.2.1. **Group Type Label**
               - **Type:** label
               - **Description:** Displays the Group type.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the column
               - **Components:**
                  None
      3.3. **Analyst Assigned Column**
         - **Type:** column
         - **Description:** Column to display the analyst assigned to the Group.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the grid
         - **Components:**
            3.3.1. **Analyst Assigned Label**
               - **Type:** label
               - **Description:** Displays the analyst assigned to the Group.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the column
               - **Components:**
                  None
      3.4. **Acronym Column**
         - **Type:** column
         - **Description:** Column to display the Group acronym.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the grid
         - **Components:**
            3.4.1. **Acronym Label**
               - **Type:** label
               - **Description:** Displays the Group acronym.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the column
               - **Components:**
                  None
      3.5. **CP Group ID Column**
         - **Type:** column
         - **Description:** Column to display the Group CP Group ID.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the grid
         - **Components:**
            3.5.1. **CP Group ID Label**
               - **Type:** label
               - **Description:** Displays the Group CP Group ID.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the column
               - **Components:**
                  None
      3.6. **Global ID Column**
         - **Type:** column
         - **Description:** Column to display the Group Global ID.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the grid
         - **Components:**
            3.6.1. **Global ID Label**
               - **Type:** label
               - **Description:** Displays the Group Global ID.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the column
               - **Components:**
                  None
      3.7. **Database Server Column**
         - **Type:** column
         - **Description:** Column to display the database server.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the grid
         - **Components:**
            3.7.1. **Database Server Label**
               - **Type:** label
               - **Description:** Displays the database server.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the column
               - **Components:**
                  None
      3.8. **Database Name Column**
         - **Type:** column
         - **Description:** Column to display the database name.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the grid
         - **Components:**
            3.8.1. **Database Name Label**
               - **Type:** label
               - **Description:** Displays the database name.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the column
               - **Components:**
                  None
      3.9. **CP File Column**
         - **Type:** column
         - **Description:** Column to display the CP file.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the grid
         - **Components:**
            3.9.1. **CP File Label**
               - **Type:** label
               - **Description:** Displays the CP file.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the column
               - **Components:**
                  None
      3.10. **Edit Column**
         - **Type:** column
         - **Description:** Column to display the edit button.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the grid
         - **Components:**
            3.10.1. **Edit Button**
               - **Type:** button
               - **Description:** Button to edit the Group.
               - **Events:**
                 - **on-click:** Opens [Edit Group Modal].
               - **Visibility:**
                 - Always visible within the column
               - **Components:**
                  3.10.1.1. **Edit Group Modal**
                     - **Type:** modal
                     - **Description:** Modal to edit the Group.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Visible when [Edit Button] is clicked
                     - **Components:**
                        3.10.1.1.1. **Close Button**
                           - **Type:** button
                           - **Description:** Closes the modal.
                           - **Events:**
                             - **on-click:** Closes [Edit Group Modal].
                           - **Visibility:**
                             - Always visible within the modal
                           - **Components:**
                              None
                        3.10.1.1.2. **Group Name Input**
                           - **Type:** input
                           - **Description:** Input to change the Group name.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible within the modal
                           - **Components:**
                              None
                        3.10.1.1.3. **Included/Excluded Container**
                           - **Type:** container
                           - **Description:** Container to display the included and excluded clients.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible within the modal
                           - **Components:**
                              3.10.1.1.3.1. **Excluded Container**
                                 - **Type:** container
                                 - **Description:** Container to display the excluded clients.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the Included/Excluded Container
                                 - **Components:**
                                    3.10.1.1.3.1.1. **Excluded Clients List**
                                       - **Type:** list
                                       - **Description:** List to display the excluded clients.
                                       - **Events:**
                                         - None
                                       - **Visibility:**
                                         - Always visible within the Excluded Container
                                       - **Components:**
                                          3.10.1.1.3.1.1.1. **Row Definition**
                                             - **Type:** row-definition
                                             - **Description:** Defines the row for the excluded clients list.
                                             - **Events:**
                                               - None
                                             - **Visibility:**
                                               - Always visible within the Excluded Clients List
                                             - **Components:**
                                                3.10.1.1.3.1.1.1.1. **Client Name Label**
                                                   - **Type:** label
                                                   - **Description:** Displays the client name.
                                                   - **Events:**
                                                     - None
                                                   - **Visibility:**
                                                     - Always visible within the row
                                                   - **Components:**
                                                      None
                              3.10.1.1.3.2. **Actions Buttons Container**
                                 - **Type:** container
                                 - **Description:** Container to display the actions buttons.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the Included/Excluded Container
                                 - **Components:**
                                    3.10.1.1.3.2.1. **Add Button**
                                       - **Type:** button
                                       - **Description:** Button to add the selected clients to the included list.
                                       - **Events:**
                                         - **on-click:** Should add the selected clients to the [Included Clients List]. Should remove the selected clients from the [Excluded Clients List].
                                       - **Visibility:**
                                         - Always visible within the Actions Buttons Container
                                       - **Components:**
                                          None
                                    3.10.1.1.3.2.2. **Add All Button**
                                       - **Type:** button
                                       - **Description:** Button to add all clients to the included list.
                                       - **Events:**
                                         - **on-click:** Should add all clients to the [Included Clients List]. Should remove all clients from the [Excluded Clients List].
                                       - **Visibility:**
                                         - Always visible within the Actions Buttons Container
                                       - **Components:**
                                          None
                                    3.10.1.1.3.2.3. **Remove Button**
                                       - **Type:** button
                                       - **Description:** Button to remove the selected clients from the included list.
                                       - **Events:**
                                         - **on-click:** Should remove the selected clients from the [Included Clients List]. Should add the selected clients to the [Excluded Clients List].
                                       - **Visibility:**
                                         - Always visible within the Actions Buttons Container
                                       - **Components:**
                                          None
                                    3.10.1.1.3.2.4. **Remove All Button**
                                       - **Type:** button
                                       - **Description:** Button to remove all clients from the included list.
                                       - **Events:**
                                         - **on-click:** Should remove all clients from the [Included Clients List]. Should add all clients to the [Excluded Clients List].
                                       - **Visibility:**
                                         - Always visible within the Actions Buttons Container
                                       - **Components:**
                                          None
                              3.10.1.1.3.3. **Included Container**
                                 - **Type:** container
                                 - **Description:** Container to display the included clients.
                                 - **Events:**
                                   - None
                                 - **Visibility:**
                                   - Always visible within the Included/Excluded Container
                                 - **Components:**
                                    3.10.1.1.3.3.1. **Included Clients List**
                                       - **Type:** list
                                       - **Description:** List to display the included clients.
                                       - **Events:**
                                         - None
                                       - **Visibility:**
                                         - Always visible within the Included Container
                                       - **Components:**
                                          3.10.1.1.3.3.1.1. **Row Definition**
                                             - **Type:** row-definition
                                             - **Description:** Defines the row for the included clients list.
                                             - **Events:**
                                               - None
                                             - **Visibility:**
                                               - Always visible within the Included Clients List
                                             - **Components:**
                                                3.10.1.1.3.3.1.1.1. **Client Name Label**
                                                   - **Type:** label
                                                   - **Description:** Displays the client name.
                                                   - **Events:**
                                                     - None
                                                   - **Visibility:**
                                                     - Always visible within the row
                                                   - **Components:**
                                                      None
                        3.10.1.1.4. **Save Group Button**
                           - **Type:** button
                           - **Description:** Button to save the changes made to the Group.
                           - **Events:**
                             - **on-click:** Saves the changes made to the Group. Closes [Edit Group Modal].
                           - **Visibility:**
                             - Always visible within the modal
                           - **Components:**
                              None
                        3.10.1.1.5. **Cancel Button**
                           - **Type:** button
                           - **Description:** Closes the modal.
                           - **Events:**
                             - **on-click:** Closes [Edit Group Modal].
                           - **Visibility:**
                             - Always visible within the modal
                           - **Components:**
                              None