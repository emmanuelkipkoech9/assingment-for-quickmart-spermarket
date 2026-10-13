# QuickMartPOS - VAT-Compliant Point of Sale (POS) System

A C# .NET Point of Sale (POS) console application built for **QuickMart Supermarket (Nairobi, Kenya)** to automate sales transaction logging and ensure full compliance with **Kenya Revenue Authority (KRA)** VAT regulations.

---

## 📌 Project Overview & Requirements

QuickMart requires an automated POS system that accurately handles Kenyan VAT rules across all retail products:
* **Standard VAT (16%)**: Most consumer goods and electronics.
* **Zero-rated VAT (0%)**: Basic food commodities (e.g., milk, bread, flour).
* **Exempt (No VAT)**: Essential services and healthcare goods (e.g., medical masks, medicine).

### Core Features:
- [x] Product categorization by VAT type.
- [x] Real-time VAT computation per line item.
- [x] Itemized, VAT-inclusive receipt generation.
- [x] Persistent sales logging to `sales_log.txt` for KRA compliance auditing.

---

## 🏗️ Project Architecture & Source Code

The solution is structured using clean Object-Oriented Programming (OOP) principles:

| File | Purpose |
| :--- | :--- |
| [`VatCategory.cs`](file:///C:/Users/mannu/AndroidStudioProjects/QuickMartPOS/VatCategory.cs) | Enum defining VAT types: `Standard`, `ZeroRated`, and `Exempt`. |
| [`VatRates.cs`](file:///C:/Users/mannu/AndroidStudioProjects/QuickMartPOS/VatRates.cs) | Global VAT rates dictionary (16% = `0.16m`, 0% = `0.00m`, Exempt = `-1.00m`). |
| [`Product.cs`](file:///C:/Users/mannu/AndroidStudioProjects/QuickMartPOS/Product.cs) | Product entity modeling price, VAT calculations, and total unit price. |
| [`SaleItem.cs`](file:///C:/Users/mannu/AndroidStudioProjects/QuickMartPOS/SaleItem.cs) | Represents a line item in a sale with quantity, subtotal, VAT, and total. |
| [`Receipt.cs`](file:///C:/Users/mannu/AndroidStudioProjects/QuickMartPOS/Receipt.cs) | Aggregates sale items, formats & prints receipt, and appends to `sales_log.txt`. |
| [`Program.cs`](file:///C:/Users/mannu/AndroidStudioProjects/QuickMartPOS/Program.cs) | Entry point simulating retail transactions and receipt generation. |
| [`QuickMartPOS.csproj`](file:///C:/Users/mannu/AndroidStudioProjects/QuickMartPOS/QuickMartPOS.csproj) | .NET project configuration. |

---

## 📸 System Execution & KRA Logging Verification

Below is the verified execution showing receipt generation and automatic logging to `sales_log.txt`:

![QuickMart POS Console Output and Transaction Log](screenshots/image1.png)

### 🧾 Sample Console Receipt Output:
```text
----- QUICKMART SUPERMARKET RECEIPT -----
Date: 2026-10-14 00:01:26
-----------------------------------------
TV x1
   Subtotal: KES 35000.00
   VAT (Standard): KES 5600.00
   Total: KES 40600.00

Milk x2
   Subtotal: KES 120.00
   VAT (ZeroRated): KES 0.00
   Total: KES 120.00

Medical Mask x5
   Subtotal: KES 100.00
   VAT (Exempt): KES 0.00
   Total: KES 100.00

-----------------------------------------
Total VAT: KES 5600.00
TOTAL: KES 40820.00
Thank you for shopping at QuickMart!
-----------------------------------------
```

### 📁 KRA Transaction Log (`sales_log.txt`):
```text
2026-10-13 23:40:00,TOTAL:KES 40720.00,VAT:KES 5600.00
2026-10-14 00:01:26,TOTAL:KES 40820.00,VAT:KES 5600.00
```

---

## 🚀 How to Run the Application

In your PowerShell or terminal, navigate to the project directory and execute:

```powershell
.\QuickMartPOS.exe
```

To view the generated KRA compliance log:
```powershell
Get-Content .\sales_log.txt
```

---

## 👨‍💻 Author & Submission Details
* **Coursework:** Class work Lesson 2 - Systematic C# .NET POS System
* **Institution:** Zetech University
