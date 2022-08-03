# Accounts

Below are the functions related to accounts.

## Create

Create an account.

### Usage

```cs
// Create Account
Accounts.Create("apiUsername", "apiPassword", "username", "password", "contactemail", "domain", "plan");
```

### Table of contents

| Name         | Related to                      |
| :----------- | :------------------------------ |
| apiUsername  | Your api username               |
| apiPassword  | Your api password               |
| username     | Account username                |
| password     | Account password                |
| contactemail | Account email                   |
| domain       | Account domain                  |
| plan         | Account plan (none for default) |

## Suspend

Suspend an account.

### Usage

```cs
// Suspend Account
Accounts.Suspend("apiUsername", "apiPassword", "username", "reason");
```

### Table of contents

| Name        | Related to                           |
| :---------- | :----------------------------------- |
| apiUsername | Your api username                    |
| apiPassword | Your api password                    |
| username    | Account username you want to suspend |
| reason      | Reason for suspending                |

## Unsuspend

Unsuspend an account.

### Usage

```cs
// Suspend Account
Accounts.Unsuspend("apiUsername", "apiPassword", "username");
```

### Table of contents

| Name        | Related to                             |
| :---------- | :------------------------------------- |
| apiUsername | Your api username                      |
| apiPassword | Your api password                      |
| username    | Account username you want to unsuspend |

## Change Password

Change the account password.

### Usage

```cs
// Suspend Account
Accounts.ChangePassword("apiUsername", "apiPassword", "username", "newpassword");
```

### Table of contents

| Name        | Related to                                   |
| :---------- | :------------------------------------------- |
| apiUsername | Your api username                            |
| apiPassword | Your api password                            |
| username    | Account username you want to change password |
| newpassword | Account new password                         |
