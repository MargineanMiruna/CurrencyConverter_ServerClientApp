# Currency Converter Server-Client App :coin:

## App description :computer:

Currency Converter is a currency conversion application that allows the user to quickly and accurately convert amounts of money into different currencies. It uses real-time exchange rates, providing access to a wide range of currencies.

The intuitive design of the application ensures a fast and simple user experience. Users can enter the desired amount, select the base currency, and the target currency, and the application quickly calculates the equivalent value in the chosen currency. To use the application:

- Enter the desired amount in the "Type amount..." field, select the base currency from the "Base currency" dropdown list, and the target currency from the "Target currency" list.
- Press the "Convert" button to obtain the converted value in the target currency. The application works on two layers: one on the client side and the other on the server side, with the two connected via TCP.

<img src="https://github.com/user-attachments/assets/62a395dd-f89f-45c7-846a-57499955e1ae" width="400" title="Figure1"/>

## Python Server :snake:

The Python server uses the socket library to establish a TCP connection and listens for requests to perform currency conversion. It utilizes the freecurrencyapi library to retrieve updated exchange rates.
The **start_server()** function starts the TCP server, which listens for client connections on port 7890. Once a client connects to the server, the client's IP address will be displayed in the console.

<img src="https://github.com/user-attachments/assets/327b20ca-0d6a-4ae3-ac11-67519fbb423a" width="400" title="Figure1"/>

After the client is connected to the server, it sends messages in the format ‘<base_currency> <target_currency> <amount>’, and the server calculates the converted amount and sends it back to the client.

## C# Client (Windows Forms) :window:

The Windows Forms application in C# provides a graphical user interface for users, allowing them to enter currency conversion details and display the result. It uses a namespace from the .NET Framework, **System.Net.Sockets**, which provides classes and methods for working with network sockets.

Text Boxes:
- amountBox - receives the amount to be converted from the user.
- baseBox - a drop-down box where the user can choose the base currency.
- targetBox - a drop-down box where the user can choose the target currency.

The buttonConvert button starts the conversion process, and the converted amount received from the server is displayed in the label3.

<img src="https://github.com/user-attachments/assets/a004216e-7095-4dd1-8f2b-ea0eb5305c62" width="400" title="Figure2"/>  <img src="https://github.com/user-attachments/assets/6e65338c-ad91-40f8-80df-78dc3d7a8b57" width="400" title="Figure3"/>

The **buttonConvert_Click()** function is executed when the user clicks the convert button. It reads the values entered in the text boxes and calls the **convert(string baseCurrency, string targetCurrency, string amount)** function. The **convert(string baseCurrency, string targetCurrency, string amount)** function sends the data to the Python server and receives the conversion result. A TCP client is created to connect to the Python server via the IP address and port 7890. The message is sent in the format ‘<base_currency> <target_currency> <amount>’, the converted amount is received from the server, and it is displayed in label3.

## Summary :bulb:

This client-server application demonstrates the efficient use of socket communication to perform real-time currency conversions. The Python server handles the main logic, using a currency exchange API to retrieve current rates and providing a quick response to client requests. The C# application offers a user-friendly interface, allowing users to enter details and view the conversion results.

[CurrencyConverterDocu.pdf](https://github.com/user-attachments/files/17791467/CurrencyConverterDocu.pdf)
