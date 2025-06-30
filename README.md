# MyUserCrudApp 👤📋

Une application web ASP.NET Core MVC permettant de **gérer une liste d'utilisateurs** via des opérations CRUD :

- ✅ Créer un utilisateur  
- 📄 Visualiser les détails d’un utilisateur  
- ✏️ Modifier ses informations  
- ❌ Supprimer un utilisateur  

---

## 🛠️ Technologies utilisées

- ASP.NET Core MVC (.NET 6+)
- Entity Framework Core avec SQLite
- Razor Pages & Bootstrap 5
- HTML5, CSS3, jQuery Validation

---

## 📸 Aperçu

<blockquote class="imgur-embed-pub" lang="en" data-id="a/heJaXFI"  ><a href="//imgur.com/a/heJaXFI">UserCrudApp</a></blockquote>
 
---

## 🚀 Lancer le projet en local

### 1. Cloner le dépôt
```bash
git clone https://github.com/ton-utilisateur/MyUserCrudApp.git
cd MyUserCrudApp
```

### 2. Restaurer les dépendances
```bash
dotnet restore
```

### 3. Générer la base de données SQLite
```bash
dotnet ef database update
```
> Nécessite le CLI EF :
> 
> dotnet tool install --global dotnet-ef

### 4. Lancer le serveur
```bash
dotnet run
```
Puis ouvrir https://localhost:7031 dans ton navigateur.

## 🧾 Exemple de données
Tu peux créer des utilisateurs avec un nom et une adresse email pour tester le système.

## 💡 Idées d'amélioration
 - 🔍 Ajout de la recherche et pagination
 - 🔐 Intégration d’une authentification (ASP.NET Core Identity)
 - 📤 Export CSV ou PDF
 - 🧪 Ajout de tests unitaires

## 📄 Licence
Ce projet est open source, librement réutilisable.

## 👤 Auteur
Thomas Lihoreau
GitHub – @tolihmto
