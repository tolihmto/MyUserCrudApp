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
 
> ![Liste des utilisateurs](https://cdn.discordapp.com/attachments/942071413169348619/1385631687483854930/image.png?ex=6856c592&is=68557412&hm=89fcb8ead1f2f1257cb36f0e8dc0cce62aedf51705b3b09354d2b6f4907079e8&)
> ![Créer un utilisateur](https://cdn.discordapp.com/attachments/942071413169348619/1385631687878377626/image.png?ex=6856c592&is=68557412&hm=3184f14c3a7341d0a0f884b3b5121403c75c936400515904e90706c289468b84&)
> ![Modifier l'utilisateur](https://cdn.discordapp.com/attachments/942071413169348619/1385631688515649749/image.png?ex=6856c592&is=68557412&hm=b618f2f71a14b52f784c65ccf3febfca9455aa6a8113493fbda22d937429bcb8&)
> ![Détails de l'utilisateur](https://cdn.discordapp.com/attachments/942071413169348619/1385631689086337126/image.png?ex=6856c592&is=68557412&hm=a711726163acc836aa18f3d600e846f12b058d790d83d385a0622e20083bf9be&)
> ![Supprimer l'utilisateur](https://cdn.discordapp.com/attachments/942071413169348619/1385631689547579524/image.png?ex=6856c592&is=68557412&hm=13e5384a9dc42e164abcabdac4d010648f57e44b9244808e67020425e0241903&)

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
