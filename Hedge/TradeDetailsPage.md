# Trade Details Page Documentation

## Components

1. **Back to Trade Management Link**
   - **Type:** Link
   - **Description:** Link to navigate to the Trade Management page.
   - **Events:**
     - **on-click:** Navigates back to the Trade Management page.
   - **Visibility:**
     - Always visible
   - **Components:**
      None

2. **Delete Trade Button**
   - **Type:** Button
   - **Description:** Button to delete the trade.
   - **Events:**
     - **on-click:** Prompts user to confirm deletion of the trade.
   - **Visibility:**
     - Always visible
   - **Components:**
      None

3. **Delete Trade Modal**
   - **Type:** Modal
   - **Description:** Modal to confirm deletion of the trade.
   - **Events:**
     - None
   - **Visibility:**
     - Visible when Delete Trade Button is clicked
   - **Components:**
      1. **Modal Close Button**
         - **Type:** Button
         - **Description:** Button to close the modal.
         - **Events:**
           - **on-click:** Closes the modal.
         - **Visibility:**
           - Always visible within the modal
         - **Components:**
            None

      2. **Modal Confirmation Message Label**
         - **Type:** Label
         - **Description:** Displays confirmation message.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible within the modal
         - **Components:**
            None

      3. **Delete Trade Button**
         - **Type:** Button
         - **Description:** Button to delete the trade.
         - **Events:**
           - **on-click:** Deletes the trade, closes the modal, navigates back to the Trade Management page.
         - **Visibility:**
           - Always visible within the modal
         - **Components:**
            None

      4. **Cancel Button**
         - **Type:** Button
         - **Description:** Button to cancel the deletion of the trade.
         - **Events:**
           - **on-click:** Closes the modal.
         - **Visibility:**
           - Always visible within the modal
         - **Components:**
            None

4. **MBS Details Container**
   - **Type:** Container
   - **Description:** Displays details of the trade.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      1. **Trade ID Label**
         - **Type:** Label
         - **Description:** Displays the trade ID.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            None

      2. **Trade Amount Label**
         - **Type:** Label
         - **Description:** Displays the trade amount.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            None

      3. **Residual Amount Label**
         - **Type:** Label
         - **Description:** Displays the residual amount.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            None

      4. **Security Type Dropdown**
         - **Type:** Dropdown
         - **Description:** Displays the security type.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            None

      5. **Trade Date Input**
         - **Type:** Input
         - **Description:** Displays the trade date.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            None

      6. **Trade Price Input**
         - **Type:** Input
         - **Description:** Displays the trade price.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            None

      7. **Settlement Date Input**
         - **Type:** Input
         - **Description:** Displays the settlement date.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            None

      8. **Broker/Dealer Input**
         - **Type:** Input
         - **Description:** Displays the broker/dealer.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            None

      9. **Trade Name Label**
         - **Type:** Label
         - **Description:** Displays the trade name.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            None

      10. **Long/Short Radio**
         - **Type:** Radio
         - **Description:** Selects the trade position (long or short).
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            1. **Buy/Long Option**
               - **Type:** Option
               - **Description:** Option to select a long position.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the radio group
               - **Components:**
                  None

            2. **Sell/Short Option**
               - **Type:** Option
               - **Description:** Option to select a short position.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible within the radio group
               - **Components:**
                  None

      11. **Transactions Container**
         - **Type:** Container
         - **Description:** Displays a list of transactions associated with the trade.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            1. **Transactions List**
               - **Type:** List
               - **Description:** Displays a list of transactions associated with the trade.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Transaction ID Label**
                     - **Type:** Label
                     - **Description:** Displays the transaction ID.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the list
                     - **Components:**
                        None

                  2. **Amount Used Input**
                     - **Type:** Input
                     - **Description:** Displays the amount used.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the list
                     - **Components:**
                        None

                  3. **Transaction Price Input**
                     - **Type:** Input
                     - **Description:** Displays the transaction price.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the list
                     - **Components:**
                        None

                  4. **Transaction Date Input**
                     - **Type:** Input
                     - **Description:** Displays the transaction date.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the list
                     - **Components:**
                        None

                  5. **Broker/Dealer Input**
                     - **Type:** Input
                     - **Description:** Displays the broker/dealer.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the list
                     - **Components:**
                        None

                  6. **Trade Name Label**
                     - **Type:** Label
                     - **Description:** Displays the trade name.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible within the list
                     - **Components:**
                        None

                  7. **Delete Transaction Button**
                     - **Type:** Button
                     - **Description:** Button to delete the transaction.
                     - **Events:**
                       - **on-click:** Prompts user to confirm deletion of the transaction.
                     - **Visibility:**
                       - Always visible within the list
                     - **Components:**
                        None

5. **Save Button**
   - **Type:** Button
   - **Description:** Button to save the trade.
   - **Events:**
     - **on-click:** Saves the trade.
   - **Visibility:**
     - Always visible
   - **Components:**
      None

6. **Cancel Button**
   - **Type:** Button
   - **Description:** Button to cancel the trade.
   - **Events:**
     - **on-click:** Closes the modal.
   - **Visibility:**
     - Always visible
   - **Components:**
      None