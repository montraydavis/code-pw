
# Overview

This document provides a comprehensive analysis of the stored procedure `{{procedureName}}`. The procedure performs the following functions:

- **Description**: {{description}}
- **Created By**: {{createdBy}}
- **Created On**: {{createdOn}}
- **Last Modified By**: {{modifiedBy}}
- **Last Modified On**: {{modifiedOn}}

## Stored Procedure Name

`{{procedureName}}`

---

## Tables and Columns

### Tables

{{#each tables}}
- **Table Name**: `{{tableName}}`
  - **Description**: {{description}}
  - **Columns**:
    {{#each columns}}
    - `{{columnName}}` ({{dataType}}): {{description}}
    {{/each}}
{{/each}}

### Views

{{#if views.length}}
{{#each views}}
- **View Name**: `{{viewName}}`
  - **Description**: {{description}}
  - **Columns**:
    {{#each columns}}
    - `{{columnName}}` ({{dataType}}): {{description}}
    {{/each}}
{{/each}}
{{else}}
_No views are involved in this stored procedure._
{{/if}}

## Stored Procedures Called

{{#if proceduresCalled.length}}
The stored procedure `{{procedureName}}` calls the following stored procedures:

{{#each proceduresCalled}}
- **Stored Procedure**: `{{procedureName}}`
  - **Description**: {{description}}
{{/each}}
{{else}}
_No stored procedures are called by this stored procedure._
{{/if}}

## Detailed Breakdown

### Input Parameters

{{#if inputParameters.length}}
The stored procedure accepts the following input parameters:

{{#each inputParameters}}
- `{{parameterName}}` ({{dataType}}): {{description}}
{{/each}}
{{else}}
_This stored procedure does not accept any input parameters._
{{/if}}

### Output Parameters

{{#if outputParameters.length}}
The stored procedure returns the following output parameters:

{{#each outputParameters}}
- `{{parameterName}}` ({{dataType}}): {{description}}
{{/each}}
{{else}}
_This stored procedure does not return any output parameters._
{{/if}}

### SQL Code

```sql
{{sqlCode}}
```

### Detailed Steps

{{#each steps}}
1. **Step Description**: {{description}}
   - **SQL Code**:
   ```sql
   {{{sqlCode}}}
   ```
   - **Tables/Views Involved**:
     {{#each tablesInvolved}}
     - `{{this}}`
     {{/each}}
   - **Stored Procedures Called**:
     {{#if proceduresCalled.length}}
     {{#each proceduresCalled}}
     - `{{this}}`
     {{/each}}
     {{else}}
     _No stored procedures called in this step._
     {{/if}}
{{/each}}
```

# Example JSON Data to Use with This Template

```json
{
  "procedureName": "usp_GetCustomerData",
  "description": "Fetches customer data based on provided customer ID.",
  "createdBy": "John Doe",
  "createdOn": "2022-01-01",
  "modifiedBy": "Jane Smith",
  "modifiedOn": "2023-06-01",
  "tables": [
    {
      "tableName": "Customers",
      "description": "Contains customer information.",
      "columns": [
        { "columnName": "CustomerID", "dataType": "INT", "description": "Primary key." },
        { "columnName": "Name", "dataType": "VARCHAR(100)", "description": "Customer's name." }
      ]
    },
    {
      "tableName": "Orders",
      "description": "Contains order information.",
      "columns": [
        { "columnName": "OrderID", "dataType": "INT", "description": "Primary key." },
        { "columnName": "CustomerID", "dataType": "INT", "description": "Foreign key to Customers." },
        { "columnName": "OrderDate", "dataType": "DATE", "description": "Date of the order." }
      ]
    }
  ],
  "views": [
    {
      "viewName": "vw_CustomerOrders",
      "description": "View of customer orders.",
      "columns": [
        { "columnName": "CustomerID", "dataType": "INT", "description": "Customer ID." },
        { "columnName": "OrderID", "dataType": "INT", "description": "Order ID." },
        { "columnName": "OrderDate", "dataType": "DATE", "description": "Order date." }
      ]
    }
  ],
  "proceduresCalled": [
    {
      "procedureName": "usp_GetOrderDetails",
      "description": "Fetches details of a specific order."
    }
  ],
  "inputParameters": [
    { "parameterName": "@CustomerID", "dataType": "INT", "description": "ID of the customer." }
  ],
  "outputParameters": [
    { "parameterName": "@OrderCount", "dataType": "INT", "description": "Number of orders for the customer." }
  ],
  "sqlCode": "SELECT * FROM Customers WHERE CustomerID = @CustomerID;",
  "steps": [
    {
      "description": "Fetch customer information.",
      "sqlCode": "SELECT * FROM Customers WHERE CustomerID = @CustomerID;",
      "tablesInvolved": ["Customers"],
      "proceduresCalled": []
    },
    {
      "description": "Fetch customer orders.",
      "sqlCode": "SELECT * FROM Orders WHERE CustomerID = @CustomerID;",
      "tablesInvolved": ["Orders"],
      "proceduresCalled": ["usp_GetOrderDetails"]
    }
  ]
}
```
