# Ticket Sales Calculator

## Description

The **Ticket Sales Calculator** is a Windows Forms application designed to help users calculate the total revenue from ticket sales for three different classes (Class A, Class B, and Class C). The user can input the number of tickets sold for each class, and the application will calculate and display the total revenue for each class as well as the overall total revenue.

## Features

- **Class-based Ticket Calculation**: Allows input for the number of tickets sold for Class A, Class B, and Class C. 
- **Revenue Calculation**: Automatically calculates the revenue for each class based on the ticket price and the number of tickets sold.
- **Total Revenue**: Displays the total revenue from all classes combined.
- **Clear Input/Output**: Includes a button to clear all inputs and outputs.
- **Error Handling**: Catches any input errors and displays appropriate messages to the user.

## How It Works

1. **Input**:  
   The user enters the number of tickets sold for each class (A, B, C) into the provided text fields.

2. **Calculate Revenue**:  
   When the **Calculate** button is clicked, the program multiplies the number of tickets sold for each class by the respective ticket price:
   - Class A ticket: $15
   - Class B ticket: $12
   - Class C ticket: $9

3. **Display Revenue**:  
   The calculated revenue for each class is displayed, and the total revenue for all classes is also shown.

4. **Clear Data**:  
   The **Clear** button allows users to reset the form, clearing both input fields and displayed results.

5. **Exit the Application**:  
   The **Exit** button closes the application.

## Installation

1. **Clone or Download the Repository**  
   Clone this repository or download the project files to your local machine.

2. **Open the Project in Visual Studio**  
   Open the project in Visual Studio or your preferred C# IDE.

3. **Build the Project**  
   Build the project by selecting **Build** > **Build Solution**.

4. **Run the Application**  
   Once the project is built, click **Start** to run the application.

## Usage

1. Enter the number of tickets sold for each class (Class A, Class B, and Class C).
2. Click **Calculate** to see the revenue for each class and the total revenue.
3. Click **Clear** to reset the form and enter new data.
4. Click **Exit** to close the application when you're done.

## Example

### Example Input:

- **Class A Tickets Sold**: 50
- **Class B Tickets Sold**: 30
- **Class C Tickets Sold**: 20

### Output:

- **Revenue from Class A**: $750.00
- **Revenue from Class B**: $360.00
- **Revenue from Class C**: $180.00
- **Total Revenue**: $1,290.00
