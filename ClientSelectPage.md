# Client Select Page Documentation

## Components

1. **Exit Client Selection Button**
   - **Type:** Button
   - **Description:** Button to exit the client selection.
   - **Events:**
     - **on-click:** Navigates back to the Dashboard page.
   - **Visibility:**
     - Displayed if a client has already been selected.
     - Hidden if no client has been selected.
   - **Components:**
      1. **Client Selection Container**
      - **Type:** Container
      - **Description:** Container to display the client selection list.

      2. **Client Search Input**
      - **Type:** Input
      - **Events:**
          - **on-change:**
          - If the input is empty, display all clients.
          - Otherwise, display clients that match the search input.

      3. **Client List**
      - **Type:** List
      - **Row Definition:**
          - **Client Name Label**
          - **Type:** Label
          - **Description:** Displays the client name.
          - **Events:**
          - **on-click:**
              - Selects the client.
              - Navigates to the Dashboard Page.
