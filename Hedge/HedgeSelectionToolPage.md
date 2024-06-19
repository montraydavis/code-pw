## Hedge Selection Tool Page Documentation

### Overview
The Hedge Selection Tool page is designed to provide users with a comprehensive set of tools to manage and analyze their hedge positions. The page is responsive to the job status, displaying certain elements only when the job status is 'REFRESHING RISK'. It includes a variety of components such as banners, buttons, containers, grids, modals, and more, each serving a specific purpose in the risk management process.

### Event-Driven Behavior
- **On SignalR Event or Page Load**: The visibility of certain components is contingent upon the job status. If the job status is 'REFRESHING RISK', the following components are visible: Refresh Risk Job Running Banner, Refresh Risk Position Button, Projections Button, Trade Assistant Button, and Clear Activity Dropdown. Otherwise, these components are not visible.

### Components

#### Toasters
- **Refresh Risk Job Status Toast**: A toaster that displays the current status of the refresh risk job.
  - **Status Label**: Shows the status message of the refresh risk job.

#### Banners
- **Refresh Risk Job Running Banner**: A banner indicating the status of the refresh risk job.
  - **Status Label**: Displays the status message of the refresh risk job.

#### Labels
- **Loans Refreshed Timestamp Label**: Shows the timestamp of the last refresh of loans.
- **Last Position Refreshed Timestamp Label**: Indicates the timestamp of the last refresh of the position.

#### Containers
- **Instruments Container**: A container for displaying the list of instruments.
  - **Actions Container**: A sub-container for user actions related to instruments.
    - **Expand All Button**: A button that, when clicked, expands all instruments.
      - **On Click**: Expands all instruments.
    - **Collapse All Link**: A link that collapses all instruments when clicked.
      - **On Click**: Collapses all instruments.
    - **Refresh Risk Position Button**: Initiates a refresh of the risk position.
      - **On Click**: Triggers the Refresh Risk Position Modal.
        - **Refresh Risk Position Modal**: A confirmation modal for refreshing the risk position.
          - **Refresh Risk Position Confirmation Message Label**: Displays a confirmation message.
          - **Modal Close Button**: Closes the modal and updates the job status indicators.
            - **On Click**: Closes the modal and updates the job status indicators.
          - **Refresh Risk Position Confirmation Button**: Confirms the refresh action and closes the modal.
            - **On Click**: Refreshes the risk position and closes the modal.
          - **Cancel Button**: Cancels the action and closes the modal.
            - **On Click**: Closes the modal.
    - **Projections Button**: Opens a modal to view projections.
      - **On Click**: Triggers the Projections Modal.
        - **Projections Modal**: Contains tabs for different projection views and related components.
          - **Close Button**: Closes the projections modal.
            - **On Click**: Closes the modal.
          - **Projected Locks Tab**: Shows projected locks details and summary.
          - **Projected Fallout Tab**: Displays projected fallout details and summary.
          - **Projected Loan Sales Tab**: Presents projected loan sales types and summaries.
          - **Additional Projections Tab**: Contains additional projections details and summary.
          - **Total Projections Tab**: Shows the total projections summary.
          - **Review Impact Button**: Reviews the impact of the trade and closes the modal.
            - **On Click**: Closes the modal.
          - **Cancel Button**: Cancels the trade and closes the modal.
            - **On Click**: Closes the modal.
    - **Trade Assistant Button**: A button to access the trade assistant feature.
    - **Clear Activity Dropdown**: Provides options to clear various activities.
      - **Clear Todays' Projections**: Includes a modal for confirmation.
        - **Clear Todays' Projections Confirmation Modal**: A modal to confirm the clearing of today's projections.
          - **Close Button**: Closes the modal.
            - **On Click**: Closes the modal.
          - **Clear Todays' Projections Confirmation Message Label**: Displays a confirmation message.
          - **Clear Todays' Projections Confirmation Button**: Confirms the clearing of today's projections.
            - **On Click**: Closes the modal.
      - **Clear Trades**: Contains a modal to confirm clearing trades.
        - **Clear Trades Confirmation Modal**: A modal to confirm the clearing of trades.
          - **Close Button**: Closes the modal.
            - **On Click**: Closes the modal.
          - **Clear Trades Confirmation Message Label**: Displays a confirmation message.
          - **Clear Trades Confirmation Button**: Confirms the clearing of trades.
            - **On Click**: Closes the modal.
      - **Clear All Activity**: Features a modal to confirm clearing all activity.
        - **Clear All Activity Confirmation Modal**: A modal to confirm the clearing of all activity.
          - **Close Button**: Closes the modal.
            - **On Click**: Closes the modal.
          - **Clear All Activity Confirmation Message Label**: Displays a confirmation message.
          - **Clear All Activity Confirmation Button**: Confirms the clearing of all activity.
            - **On Click**: Closes the modal.

- **Trade Blotter Container**: Displays the trade blotter and related components.
  - **Last Refreshed Timestamp Label**: Indicates the last refresh time of the trade blotter.
  - **Broker/Dealer Usage Link**: Opens a modal to view broker/dealer usage.
    - **On Click**: Triggers the Broker/Dealer Usage Modal.
      - **Broker/Dealer Usage Modal**: Contains a grid showing broker/dealer usage.
        - **Close Button**: Closes the modal.
          - **On Click**: Closes the modal.
        - **Broker/Dealer Usage Grid**: Shows the usage of broker/dealers.
  - **Trade Blotter Grid**: Lists trades with options to propose, enter, or delete trades.
    - **Select Checkbox**: Allows selection of trades for further actions.
      - **On Selected**: Updates the selected trade blotter grid.
      - **On Unselected**: Updates the selected trade blotter grid to exclude the trade.
    - **Propose Trade Button**: Initiates the trade proposal process.
      - **On Click**: Triggers the Propose Trade Confirmation Modal.
        - **Propose Trade Confirmation Modal**: A modal to confirm the proposal of the trade.
          - **Trade Details Container**: Displays the trade details.
          - **Review Impact Button**: Reviews the impact of the trade.
            - **On Click**: Closes the modal.
          - **Cancel Button**: Cancels the trade.
            - **On Click**: Closes the modal.
        - **Usage Tab**: Displays the usage details.
        - **Coverage Tab**: Displays the coverage details.
        - **Trades Tab**: Displays the trades.
          - **Net Totals Container**: Displays the net totals.
    - **Enter Trade Button**: Confirms the addition of a trade.
      - **On Click**: Triggers the Enter Trade Confirmation Modal.
        - **Enter Trade Confirmation Modal**: A modal to confirm the addition of the trade.
          - **Close Button**: Closes the modal.
            - **On Click**: Closes the modal.
          - **Enter Trade Confirmation Message Label**: Displays the confirmation message.
          - **Add Trade Confirmation Button**: Confirms the addition of the trade.
            - **On Click**: Closes the modal.
          - **Cancel Button**: Cancels the modal.
            - **On Click**: Closes the modal.
    - **Delete Trade Button**: Removes a trade from the blotter.
      - **On Click**: Triggers the Delete Trade Confirmation Modal.
        - **Delete Trade Confirmation Modal**: A modal to confirm the deletion of the trade.
          - **Close Button**: Closes the modal.
            - **On Click**: Closes the modal.
          - **Delete Trade Confirmation Message Label**: Displays the confirmation message.
          - **Delete Trade Button**: Deletes the trade.
            - **On Click**: Deletes the trade and closes the modal.
          - **Cancel Button**: Cancels the modal.
            - **On Click**: Closes the modal.
    - **Update Selected Button**: Allows updating of selected trades in the blotter.
      - **On Click**: Triggers the Update Selected Confirmation Modal.
        - **Update Selected Confirmation Modal**: A modal to confirm the update of the selected trades.
          - **Close Button**: Closes the modal.
            - **On Click**: Closes the modal.
          - **Update Selected Confirmation Message Label**: Displays the confirmation message.
          - **Add Trade Button**: Confirms the addition of the selected trades.
            - **On Click**: Closes the modal.
          - **Cancel Button**: Cancels the modal.
            - **On Click**: Closes the modal.
    - **Associate Trades Button**: Initiates the process to associate selected trades.
      - **On Click**: Triggers the Associate Trades Confirmation Modal.
        - **Associate Trades Confirmation Modal**: A modal to confirm the association of the selected trades.
          - **Close Button**: Closes the modal.
            - **On Click**: Closes the modal.
          - **Trade Associations List**: Lists the trades to associate.
          - **Save Button**: Saves the association.
            - **On Click**: Closes the modal.

#### Modals
- **Errors On Page Modal**: Displays when there are errors on the page.
  - **Close Button**: Closes the modal.
  - **Errors List**: Lists the errors present on the page.
  - **Ok Button**: Acknowledges the errors and closes the modal.