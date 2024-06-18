# Trade Confirmations Page Documentation

## Components

1. **Blind Confirms Tab**
   - **Type:** Tab
   - **Description:** Tab for blind confirmations.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      1. **Browse Files Button**
         - **Type:** Button
         - **Description:** Button to browse files for upload.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            None

      2. **Upload Selected Files Button**
         - **Type:** Button
         - **Description:** Button to upload selected files.
         - **Events:**
           - None
         - **Visibility:**
           - Enabled if the confirmation file count is greater than 0
           - Disabled otherwise
         - **Components:**
            None

      3. **Upload Files Input**
         - **Type:** File Input
         - **Description:** Input for uploading files.
         - **Events:**
           - **on-change:** Updates the Uploaded Confirms Grid to include the selected file.
         - **Visibility:**
           - Always visible
         - **Components:**
            None

      4. **Uploaded Confirms Grid**
         - **Type:** Grid
         - **Description:** Displays the uploaded confirms.
         - **Events:**
           - None
         - **Visibility:**
           - Displayed if the confirmation file count is greater than 0
           - Hidden otherwise
         - **Components:**
            1. **File Name Column**
               - **Type:** Column
               - **Description:** Column for file names.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **File Name Label**
                     - **Type:** Label
                     - **Description:** Displays the file name.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

            2. **Confirms Included Column**
               - **Type:** Column
               - **Description:** Column for the number of confirms included.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Confirms Included Label**
                     - **Type:** Label
                     - **Description:** Dropdown to select the number of confirms included.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

            3. **Confirm Name Column**
               - **Type:** Column
               - **Description:** Column for confirm names.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Confirm Name Input**
                     - **Type:** Input
                     - **Description:** Input to set the confirm name.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

            4. **Actions Column**
               - **Type:** Column
               - **Description:** Column for actions related to confirms.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Delete Button**
                     - **Type:** Button
                     - **Description:** Button to delete the confirm.
                     - **Events:**
                       - **on-click:** Deletes the confirm.
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

      5. **Available Confirms for Matching Container**
         - **Type:** Container
         - **Description:** Container for available confirms for matching.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            1. **Trade Confirms Grid**
               - **Type:** Grid
               - **Description:** Displays the trade confirms.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Confirm Name Column**
                     - **Type:** Column
                     - **Description:** Column for confirm names.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Confirm Name Label**
                           - **Type:** Label
                           - **Description:** Displays the confirm name.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

                  2. **Date Uploaded Column**
                     - **Type:** Column
                     - **Description:** Column for dates uploaded.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Date Uploaded Label**
                           - **Type:** Label
                           - **Description:** Displays the date uploaded.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

                  3. **Confirmed Trades Column**
                     - **Type:** Column
                     - **Description:** Column for confirmed trades.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Confirmed Trades Label**
                           - **Type:** Label
                           - **Description:** Displays the confirmed trades.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

                  4. **Actions Column**
                     - **Type:** Column
                     - **Description:** Column for actions related to trade confirms.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Select Button**
                           - **Type:** Button
                           - **Description:** Button to select the trade confirm.
                           - **Events:**
                             - **on-click:** Opens the Select Confirmation Modal.
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

                        2. **Delete Button**
                           - **Type:** Button
                           - **Description:** Button to delete the trade confirm.
                           - **Events:**
                             - **on-click:** Opens the Delete Confirmation Modal.
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

      6. **Select Confirmation Modal**
         - **Type:** Modal
         - **Description:** Modal to confirm the selection of a trade confirm.
         - **Events:**
           - None
         - **Visibility:**
           - Visible when triggered by Select Button
         - **Components:**
            1. **Close Button**
               - **Type:** Button
               - **Description:** Button to close the modal.
               - **Events:**
                 - **on-click:** Closes the modal.
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            2. **Broker/Dealer Dropdown**
               - **Type:** Dropdown
               - **Description:** Dropdown to select the broker/dealer.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            3. **Buy/Sell Dropdown**
               - **Type:** Dropdown
               - **Description:** Dropdown to select the buy/sell.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            4. **Instrument Dropdown**
               - **Type:** Dropdown
               - **Description:** Dropdown to select the instrument.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            5. **Trade Date Input**
               - **Type:** Input
               - **Description:** Input to enter the trade date.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            6. **Settlement Date Input**
               - **Type:** Input
               - **Description:** Input to enter the settlement date.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            7. **Trade Amount Input**
               - **Type:** Input
               - **Description:** Input to enter the trade amount.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            8. **Price Input**
               - **Type:** Input
               - **Description:** Input to enter the price.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            9. **Search Button**
               - **Type:** Button
               - **Description:** Button to search for the trade confirm.
               - **Events:**
                 - **on-click:** Searches for the Trade Confirm PDF Viewer that matches the criteria.
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            10. **Document Viewer Container**
                - **Type:** Container
                - **Description:** Displays PDF view of the trade confirm.
                - **Events:**
                  - None
                - **Visibility:**
                  - Visible when a Trade Confirm PDF Viewer is found
                - **Components:**
                   1. **Trade Confirm PDF Viewer**
                      - **Type:** PDF Viewer
                      - **Description:** Displays the trade confirm.
                      - **Events:**
                        - None
                      - **Visibility:**
                        - Always visible
                      - **Components:**
                         None

      7. **Delete Confirmation Modal**
         - **Type:** Modal
         - **Description:** Modal to confirm the deletion of a trade confirm.
         - **Events:**
           - None
         - **Visibility:**
           - Visible when triggered by Delete Button
         - **Components:**
            1. **Close Button**
               - **Type:** Button
               - **Description:** Button to close the modal.
               - **Events:**
                 - **on-click:** Closes the modal.
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            2. **Confirm Delete Message Label**
               - **Type:** Label
               - **Description:** Displays the confirmation message.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            3. **Confirm Delete Button**
               - **Type:** Button
               - **Description:** Button to confirm the deletion.
               - **Events:**
                 - **on-click:** Deletes the selected trade confirm and closes the modal.
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            4. **Cancel Button**
               - **Type:** Button
               - **Description:** Button to cancel the deletion.
               - **Events:**
                 - **on-click:** Closes the modal.
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

2. **Verbal Confirms Tab**
   - **Type:** Tab
   - **Description:** Tab for verbal confirmations.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      1. **Verbal Confirms Grid**
         - **Type:** Grid
         - **Description:** Displays the verbal confirms.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            1. **Trade ID Column**
               - **Type:** Column
               - **Description:** Column for trade IDs.
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

            2. **Transaction ID Column**
               - **Type:** Column
               - **Description:** Column for transaction IDs.
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
                       - Always visible
                     - **Components:**
                        None

            3. **Long/Short Column**
               - **Type:** Column
               - **Description:** Column for long/short positions.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Long/Short Label**
                     - **Type:** Label
                     - **Description:** Displays the long/short.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

            4. **Instrument Column**
               - **Type:** Column
               - **Description:** Column for instruments.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Instrument Label**
                     - **Type:** Label
                     - **Description:** Displays the instrument.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

            5. **Trade Date Column**
               - **Type:** Column
               - **Description:** Column for trade dates.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Trade Date Label**
                     - **Type:** Label
                     - **Description:** Displays the trade date.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

            6. **Settlement Date Column**
               - **Type:** Column
               - **Description:** Column for settlement dates.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Settlement Date Label**
                     - **Type:** Label
                     - **Description:** Displays the settlement date.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

            7. **Trade Amount Column**
               - **Type:** Column
               - **Description:** Column for trade amounts.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Trade Amount Label**
                     - **Type:** Label
                     - **Description:** Displays the trade amount.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

            8. **Trade Price Column**
               - **Type:** Column
               - **Description:** Column for trade prices.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Trade Price Label**
                     - **Type:** Label
                     - **Description:** Displays the trade price.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

            9. **Broker/Dealer Column**
               - **Type:** Column
               - **Description:** Column for broker/dealers.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Broker/Dealer Label**
                     - **Type:** Label
                     - **Description:** Displays the broker/dealer.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

            10. **Confirm Now Column**
                - **Type:** Column
                - **Description:** Column for immediate trade confirmation.
                - **Events:**
                  - None
                - **Visibility:**
                  - Always visible
                - **Components:**
                   1. **Confirm Now Button**
                      - **Type:** Button
                      - **Description:** Button to confirm the trade.
                      - **Events:**
                        - **on-click:** Opens the Confirm Confirmation Modal.
                      - **Visibility:**
                        - Always visible
                      - **Components:**
                         None

      2. **Confirm Confirmation Modal**
         - **Type:** Modal
         - **Description:** Modal to confirm the trade.
         - **Events:**
           - None
         - **Visibility:**
           - Visible when triggered by Confirm Now Button
         - **Components:**
            1. **Close Button**
               - **Type:** Button
               - **Description:** Button to close the modal.
               - **Events:**
                 - **on-click:** Closes the modal.
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            2. **Details Container**
               - **Type:** Container
               - **Description:** Container for trade details.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **ID Label**
                     - **Type:** Label
                     - **Description:** Displays the row ID.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

                  2. **Trade ID Label**
                     - **Type:** Label
                     - **Description:** Displays the trade ID.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None
                  3. **Transaction ID Label**
                     - **Type:** Label
                     - **Description:** Displays the transaction ID.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

                  4. **Long/Short Label**
                     - **Type:** Label
                     - **Description:** Displays whether the position is long or short.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

                  5. **Trade Date Label**
                     - **Type:** Label
                     - **Description:** Displays the trade date.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

                  6. **Settlement Date Label**
                     - **Type:** Label
                     - **Description:** Displays the settlement date.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

                  7. **Original Trade Amount Label**
                     - **Type:** Label
                     - **Description:** Displays the original trade amount.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

                  8. **Trade Price Label**
                     - **Type:** Label
                     - **Description:** Displays the trade price.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

                  9. **Broker/Dealer Label**
                     - **Type:** Label
                     - **Description:** Displays the broker/dealer.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        None

            3. **Confirm Button**
               - **Type:** Button
               - **Description:** Button to confirm the trade.
               - **Events:**
                 - **on-click:** Closes the modal.
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

            4. **Cancel Button**
               - **Type:** Button
               - **Description:** Button to cancel the modal.
               - **Events:**
                 - **on-click:** Closes the modal.
               - **Visibility:**
                 - Always visible
               - **Components:**
                  None

3. **Unconfirmed Trades/Transactions Tab**
   - **Type:** Tab
   - **Description:** Tab for unconfirmed trades/transactions.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      1. **Unconfirmed Trades/Transactions Grid**
         - **Type:** Grid
         - **Description:** Displays the unconfirmed trades/transactions.
         - **Events:**
           - None
         - **Visibility:**
           - Always visible
         - **Components:**
            1. **Trade Details Column**
               - **Type:** Column
               - **Description:** Column for trade details.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Trade ID Sub-Column**
                     - **Type:** Sub-Column
                     - **Description:** Sub-column for trade IDs.
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

                  2. **Transaction ID Sub-Column**
                     - **Type:** Sub-Column
                     - **Description:** Sub-column for transaction IDs.
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
                             - Always visible
                           - **Components:**
                              None

                  3. **Instrument Sub-Column**
                     - **Type:** Sub-Column
                     - **Description:** Sub-column for instruments.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Instrument Label**
                           - **Type:** Label
                           - **Description:** Displays the instrument.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

                  4. **Trade Amount Sub-Column**
                     - **Type:** Sub-Column
                     - **Description:** Sub-column for trade amounts.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Trade Amount Label**
                           - **Type:** Label
                           - **Description:** Displays the trade amount.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

                  5. **Long/Short Sub-Column**
                     - **Type:** Sub-Column
                     - **Description:** Sub-column for long/short positions.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Long/Short Label**
                           - **Type:** Label
                           - **Description:** Displays the long/short.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

            2. **Dealer Column**
               - **Type:** Column
               - **Description:** Column for dealer information.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Broker/Dealer Sub-Column**
                     - **Type:** Sub-Column
                     - **Description:** Sub-column for broker/dealer information.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Broker/Dealer Label**
                           - **Type:** Label
                           - **Description:** Displays the broker/dealer.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

            3. **Dates Column**
               - **Type:** Column
               - **Description:** Column for date information.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Trade Date Sub-Column**
                     - **Type:** Sub-Column
                     - **Description:** Sub-column for trade dates.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Trade Date Label**
                           - **Type:** Label
                           - **Description:** Displays the trade date.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

                  2. **Settlement Date Sub-Column**
                     - **Type:** Sub-Column
                     - **Description:** Sub-column for settlement dates.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Settlement Date Label**
                           - **Type:** Label
                           - **Description:** Displays the settlement date.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

            4. **Trade Column**
               - **Type:** Column
               - **Description:** Column for trade information.
               - **Events:**
                 - None
               - **Visibility:**
                 - Always visible
               - **Components:**
                  1. **Trade Price Sub-Column**
                     - **Type:** Sub-Column
                     - **Description:** Sub-column for trade prices.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Trade Price Label**
                           - **Type:** Label
                           - **Description:** Displays the trade price.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

                  2. **Trader Sub-Column**
                     - **Type:** Sub-Column
                     - **Description:** Sub-column for trader information.
                     - **Events:**
                       - None
                     - **Visibility:**
                       - Always visible
                     - **Components:**
                        1. **Trader Label**
                           - **Type:** Label
                           - **Description:** Displays the trader.
                           - **Events:**
                             - None
                           - **Visibility:**
                             - Always visible
                           - **Components:**
                              None

4. **Trade Type Dropdown**
   - **Type:** Dropdown
   - **Description:** Dropdown to select the trade type.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      None

5. **Investor Dropdown**
   - **Type:** Dropdown
   - **Description:** Dropdown to select the investor.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      None

6. **Commitment Amount Dropdown**
   - **Type:** Dropdown
   - **Description:** Dropdown to select the commitment amount.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      None

7. **Price Dropdown**
   - **Type:** Dropdown
   - **Description:** Dropdown to select the price.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      None

8. **Notes Dropdown**
   - **Type:** Dropdown
   - **Description:** Dropdown for notes.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      None

9. **Commitment ID Input**
   - **Type:** Input
   - **Description:** Input for entering the commitment ID.
   - **Events:**
     - None
   - **Visibility:**
     - Always visible
   - **Components:**
      None

10. **Expiration Date Input**
    - **Type:** Input
    - **Description:** Input for entering the expiration date.
    - **Events:**
      - None
    - **Visibility:**
      - Always visible
    - **Components:**
       None

11. **Loans Container**
    - **Type:** Container
    - **Description:** Container for displaying loans.
    - **Events:**
      - None
    - **Visibility:**
      - Always visible
    - **Components:**
       1. **Loans Grid**
          - **Type:** Grid
          - **Description:** Displays the loans.
          - **Events:**
            - None
          - **Visibility:**
            - Always visible
          - **Components:**
             1. **Index Column**
                - **Type:** Column
                - **Description:** Column for index numbers.
                - **Events:**
                  - None
                - **Visibility:**
                  - Always visible
                - **Components:**
                   1. **Index Label**
                      - **Type:** Label
                      - **Description:** Displays the index.
                      - **Events:**
                        - None
                      - **Visibility:**
                        - Always visible
                      - **Components:**
                         None

             2. **Loan ID Column**
                - **Type:** Column
                - **Description:** Column for loan IDs.
                - **Events:**
                  - None
                - **Visibility:**
                  - Always visible
                - **Components:**
                   1. **Loan ID Label**
                      - **Type:** Label
                      - **Description:** Displays the loan ID.
                      - **Events:**
                        - None
                      - **Visibility:**
                        - Always visible
                      - **Components:**
                         None

             3. **Price Column**
                - **Type:** Column
                - **Description:** Column for prices.
                - **Events:**
                  - None
                - **Visibility:**
                  - Always visible
                - **Components:**
                   1. **Price Label**
                      - **Type:** Label
                      - **Description:** Displays the price.
                      - **Events:**
                        - None
                      - **Visibility:**
                        - Always visible
                      - **Components:**
                         None

12. **Create Button**
    - **Type:** Button
    - **Description:** Button to create a new loan.
    - **Events:**
      - **on-click:** Opens the Create Loan Confirmation Modal.
    - **Visibility:**
      - Always visible
    - **Components:**
       None

13. **Create Loan Confirmation Modal**
    - **Type:** Modal
    - **Description:** Modal to confirm the creation of a loan.
    - **Events:**
      - None
    - **Visibility:**
      - Visible when triggered by Create Button
    - **Components:**
       1. **Close Button**
          - **Type:** Button
          - **Description:** Button to close the modal.
          - **Events:**
            - **on-click:** Closes the modal.
          - **Visibility:**
            - Always visible
          - **Components:**
             None

       2. **Create Loan Confirmation Message Label**
          - **Type:** Label
          - **Description:** Displays the confirmation message.
          - **Events:**
            - None
          - **Visibility:**
            - Always visible
          - **Components:**
             None

       3. **Create Loan Button**
          - **Type:** Button
          - **Description:** Button to create the loan.
          - **Events:**
            - **on-click:** Closes the modal.
          - **Visibility:**
            - Always visible
          - **Components:**
             None

       4. **Cancel Button**
          - **Type:** Button
          - **Description:** Button to cancel the modal.
          - **Events:**
            - **on-click:** Closes the modal.
          - **Visibility:**
            - Always visible
          - **Components:**
             None

14. **Cancel Button**
    - **Type:** Button
    - **Description:** Button to cancel the current action.
    - **Events:**
      - None
    - **Visibility:**
      - Always visible
    - **Components:**
       None