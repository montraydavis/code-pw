# LOS Configuration Page Documentation

## Components

1. **LOS Connection Dropdown**
   - **Type:** dropdown
   - **Description:** Dropdown to select the LOS connection.
   - **Events:**
     None
   - **Visibility:**
     None
   - **Components:**
     None

2. **Authentication Settings Container**
   - **Type:** container
   - **Description:** Container to display the authentication settings.
   - **Events:**
     None
   - **Visibility:**
     None
   - **Components:**
     2.1. **LOS ID Input**
         - **Type:** input
         - **Description:** Input to enter the LOS ID.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     2.2. **LOS URL Input**
         - **Type:** input
         - **Description:** Input to enter the LOS URL.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     2.3. **LOS Version Dropdown**
         - **Type:** dropdown
         - **Description:** Dropdown to select the LOS version.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     2.4. **Username Input**
         - **Type:** input
         - **Description:** Input to enter the username.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     2.5. **Password Input**
         - **Type:** input
         - **Description:** Input to enter the password.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     2.6. **Confirm Password Input**
         - **Type:** input
         - **Description:** Input to confirm the password.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None

3. **CompassPoint Settings Container**
   - **Type:** container
   - **Description:** Container to display the CompassPoint settings.
   - **Events:**
     None
   - **Visibility:**
     None
   - **Components:**
     3.1. **Enable RTR Checkbox**
         - **Type:** checkbox
         - **Description:** Checkbox to enable RTR.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     3.2. **LOS Filter Input**
         - **Type:** input
         - **Description:** Input to enter the LOS filter.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     3.3. **Test Filter Button**
         - **Type:** button
         - **Description:** Button to test the filter.
         - **Events:**
           - **on-click:** Should display Test Filter Modal.
         - **Visibility:**
           None
         - **Components:**
           3.3.1. **Test Filter Modal**
               - **Type:** modal
               - **Description:** Modal to display the test filter results.
               - **Events:**
                 None
               - **Visibility:**
                 None
               - **Components:**
                 3.3.1.1. **Close Button**
                     - **Type:** button
                     - **Description:** Button to close the modal.
                     - **Events:**
                       - **on-click:** Should close Test Filter Modal.
                     - **Visibility:**
                       None
                     - **Components:**
                       None
                 3.3.1.2. **Filter Validation Label**
                     - **Type:** label
                     - **Description:** Label to display the filter validation.
                     - **Events:**
                       - **@on-load:** Should display Filter Validation Label with the appropriate text based on the validity of LOS Filter Input.
                     - **Visibility:**
                       None
                     - **Components:**
                       None
                 3.3.1.3. **Ok Button**
                     - **Type:** button
                     - **Description:** Button to close the modal.
                     - **Events:**
                       - **on-click:** Should close Test Filter Modal.
                     - **Visibility:**
                       None
                     - **Components:**
                       None
     3.4. **Snapshot Table Name Input**
         - **Type:** input
         - **Description:** Input to enter the snapshot table name.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None

4. **Communication Settings Container**
   - **Type:** container
   - **Description:** Container to display the communication settings.
   - **Events:**
     None
   - **Visibility:**
     None
   - **Components:**
     4.1. **Number Of Retries Dropdown**
         - **Type:** dropdown
         - **Description:** Dropdown to select the number of retries.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     4.2. **Retry Interval Dropdown**
         - **Type:** dropdown
         - **Description:** Dropdown to select the retry interval.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     4.3. **Save Kiab Wait Period Dropdown**
         - **Type:** dropdown
         - **Description:** Dropdown to select the save Kiab wait period.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     4.4. **Timeout Seconds Dropdown**
         - **Type:** dropdown
         - **Description:** Dropdown to select the timeout seconds.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     4.5. **Emails Input**
         - **Type:** input
         - **Description:** Input to enter the emails.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None

5. **Pooling Writeback Container**
   - **Type:** container
   - **Description:** Container to display the pooling writeback settings.
   - **Events:**
     None
   - **Visibility:**
     None
   - **Components:**
     5.1. **New Request Checkbox**
         - **Type:** checkbox
         - **Description:** Checkbox to enable new request.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     5.2. **New Request Tooltip**
         - **Type:** tooltip
         - **Description:** Tooltip to display the new request tooltip.
         - **Events:**
           - **on-hover:** Should display New Request Tooltip.
           - **on-mouseleave:** Should hide New Request Tooltip.
         - **Visibility:**
           None
         - **Components:**
           None
     5.3. **New Request Info**
         - **Type:** info
         - **Description:** Info to display the new request info.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None

6. **Other Settings Container**
   - **Type:** container
   - **Description:** Container to display the other settings.
   - **Events:**
     None
   - **Visibility:**
     None
   - **Components:**
     6.1. **Enable Check for LOS Updates Checkbox**
         - **Type:** checkbox
         - **Description:** Checkbox to enable check for LOS updates.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     6.2. **LOS Update Open Timeout Input**
         - **Type:** input
         - **Description:** Input to enter the LOS update open timeout.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     6.3. **LOS Update Chase Timeout Input**
         - **Type:** input
         - **Description:** Input to enter the LOS update chase timeout.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     6.4. **Polling Interval Input**
         - **Type:** input
         - **Description:** Input to enter the polling interval.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     6.5. **LOS Polling Data Modified Field Input**
         - **Type:** input
         - **Description:** Input to enter the LOS polling data modified field.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     6.6. **Snapshot Table In Use Checkbox**
         - **Type:** checkbox
         - **Description:** Checkbox to enable snapshot table in use.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     6.7. **Snapshot Last Updated Input**
         - **Type:** input
         - **Description:** Input to enter the snapshot last updated.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     6.8. **Retry Save Loans in Process Checkbox**
         - **Type:** checkbox
         - **Description:** Checkbox to enable retry save loans in process.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None
     6.9. **Last Retry Save Loans in Process Input**
         - **Type:** input
         - **Description:** Input to enter the last retry save loans in process.
         - **Events:**
           None
         - **Visibility:**
           None
         - **Components:**
           None

7. **Save Confirmation Button**
   - **Type:** button
   - **Description:** Button to save the changes made to the LOS configuration.
   - **Events:**
     None
   - **Visibility:**
     None
   - **Components:**
     None

8. **Cancel Button**
   - **Type:** button
   - **Description:** Button to cancel the action.
   - **Events:**
     None
   - **Visibility:**
     None
   - **Components:**
     None