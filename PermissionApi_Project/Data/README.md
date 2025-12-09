# Permission API — REST API לניהול משתמשים ותפקידים

## Overview
Permission API הוא פרויקט המדגים בנייה של REST API לניהול משתמשים (Users)
ותפקידים (Roles) באמצעות ‎ASP.NET Core 8‎.

המערכת מאפשרת:
- יצירה ושליפה של משתמשים
- יצירה ושליפה של תפקידים
- מחיקת משתמש
- שיוך תפקיד למשתמש
- שימוש ב־FakeDataStore לשמירה זמנית בזיכרון
- בדיקה מלאה דרך Swagger UI

הפרויקט מיועד ללימוד, להגשה או להדגמה בראיונות.

## Features
✔️ ניהול משתמשים — GET / POST / DELETE  
✔️ ניהול תפקידים — GET / POST  
✔️ שיוך תפקיד למשתמש — POST  
✔️ שימוש ב־Controllers ורוטינג תקני  
✔️ תיעוד ובדיקה עם Swagger  
✔️ קוד קצר, ברור ומאורגן  

## Project Structure
PermissionApi_Project
│
├── Controllers
│   ├── UsersController.cs
│   └── RolesController.cs
│
├── Data
│   ├── FakeDataStore.cs
│   └── ApplicationDbContext.cs
│
├── Models
│   ├── User.cs
│   ├── Role.cs
│   └── UserRole.cs
│
├── Program.cs
├── appsettings.json
└── launchSettings.json
