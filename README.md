# 💎 Zovelo – Jewelry E-Commerce Website

Zovelo is a custom-built, responsive jewelry e-commerce website designed and developed by **Kenshin Angcaya** as part of a personal portfolio and freelance project.  
It was created for a real-world brand — **Zovelo**, a jewelry business based in the Philippines, owned by a friend of the developer.

This project showcases a full-stack .NET Core implementation of a modern online shopping experience.

---

## 🚀 Features

- 🛙️ Browse and view detailed jewelry products
- 🛒 Add-to-cart and quantity management
- 👤 Secure user authentication (register & login)
- 🔍 Product search/filter functionality
- 📅 Real database using SQL Server LocalDB
- 📱 Fully responsive layout using Bootstrap

---

## 🧰 Tech Stack

- **Frontend**: HTML, CSS, Bootstrap 5
- **Backend**: C#, ASP.NET Core MVC
- **Database**: SQL Server LocalDB
- **ORM**: Entity Framework Core
- **Tools**: Visual Studio, Git, GitHub

---

## 🌟 Purpose

- ✅ Designed to practice and demonstrate full-stack development
- ✅ Built for a real business: Zovelo (Philippines-based jewelry brand)
- ✅ Showcases product display, shopping cart logic, and responsive design

---

## 📁 Project Structure

```bash
Testing1/
├── Areas/
│   └── Identity/
│       └── Pages/
├── Controllers/
│   ├── CartController.cs
│   └── HomeController.cs
├── Models/
│   ├── CartItem.cs
│   ├── ErrorViewModel.cs
│   └── Product.cs
├── Views/
│   ├── Cart/
│   │   └── Index.cshtml
│   ├── Home/
│   │   ├── Catalogue.cshtml
│   │   ├── Index.cshtml
│   │   ├── Privacy.cshtml
│   │   ├── ProductDetails.cshtml
│   │   └── ProductDetails.cshtml.cs
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _Layout.cshtml.css
│   │   ├── _LoginPartial.cshtml
│   │   ├── _ValidationScriptsPartial.cshtml
│   │   └── Error.cshtml
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
├── wwwroot/
│   ├── css/
│   ├── js/
│   ├── Images/
│   └── lib/
├── Data/
│   ├── ApplicationDbContext.cs
│   └── Migrations/
├── Services/
│   └── ShoppingCartService.cs
├── Properties/
│   ├── launchSettings.json
│   ├── serviceDependencies.json
│   └── serviceDependencies.local.json
├── appsettings.Development.json
├── appsettings.json
├── Program.cs
├── Zovelo.csproj
└── Testing1Application.sln
```

---

## 🛠️ How to Run Locally

1. Clone the repository  
   ```bash
   git clone https://github.com/Keeenshin/Zovelo.git
   ```

2. Open the solution in **Visual Studio**

3. Make sure **SQL Server LocalDB** is running  
   (or attach `ZoveloDB.mdf` using SSMS if needed)

4. Build and run the project (press **F5**)

---

> 🗃️ To run this project fully, attach the included database file:

1. Open **SQL Server Management Studio (SSMS)**
2. Right-click on `Databases` → choose `Attach...`
3. Browse to the `/database/ZoveloDB.mdf` file
4. Click OK — the database will show up in SSMS
5. Run the app in Visual Studio (F5) ✅

---

## 📸 Screenshots

- Homepage
![image](https://github.com/user-attachments/assets/c28611e6-7d1c-4629-b02e-476e10bec2cb)
![image](https://github.com/user-attachments/assets/dc3e59a9-ff4c-49ef-99b9-55cf4eea52d4)
![image](https://github.com/user-attachments/assets/4db3e342-1b2a-4140-9bcf-5e2c51d601c9)

- Product catalog
![image](https://github.com/user-attachments/assets/4f3c13f3-cca7-446b-87b4-12e733c12943)

- Product detail view
![image](https://github.com/user-attachments/assets/3439adc5-54c3-4539-b67a-91a13a8465b3)

- Shopping cart
![image](https://github.com/user-attachments/assets/7ac46e13-137c-471c-8ff9-c5688a4597eb)

---

## 👨‍💻 Developer

**Kenshin Angcaya**  
Final-year IT student | Aspiring Full-Stack Developer  
🇦🇺 Based in Brisbane, Australia

🔗 [GitHub](https://github.com/Keeenshin) • [Portfolio Website](#)

---

_This project is part of Kenshin's professional portfolio and a real collaboration with a Filipino jewelry business._

