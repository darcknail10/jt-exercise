# Product Order Web Application

This ASP.NET Core MVC web application displays a list of products and orders. The data for products and orders is loaded from the `products.json` and `orders.json` files. You can also modify and add some data to the attached JSON files.

## Features

- **Store**: Displays a list of products with their names and prices.
- **My Orders**: Displays a list of orders with their IDs and net prices.

## Prerequisites

Before you begin, ensure you have the following installed:

- [.NET SDK 8.x](https://dotnet.microsoft.com/download/dotnet) on your local machine.
- A suitable code editor, such as Visual Studio with the updated version with .Net8.


## Setup Instructions

### 1. Clone the Repository

To get started, clone the project repository from GitHub:

```bash
git clone https://github.com/darcknail10/jt-exercise.git
```


### 2. Install NuGet Packages

Using Visual Studio:

1. In Solution Explorer, right-click on the project and select Manage NuGet Packages.
2. Go to the Browse tab, search for System.Text.Json, and install it. This package is necessary for JSON serialization.

Using VS Code:

1. Ctrl+Shift+P -> Nuget Add: then search of Nuget you want to install
   

### 3. Run Code by pressing the F5 - https://localhost:7143/
