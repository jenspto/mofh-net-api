# Domains

Below are the functions related to domains.

## Check if available

Check a (sub)domain if is avaible

### Usage

```cs
// Check if available
Domains.CheckAvailable("apiUsername", "apiPassword", "domain");
```

### Table of contents

| Name         | Related to                      |
| :----------- | :------------------------------ |
| apiUsername  | Your api username               |
| apiPassword  | Your api password               |
| domain       | Domain to check                 |

## Get User domain(s)

Get all domain(s) for the user.
### Usage

```cs
// Get User domain
Domains.GetUserDomains("apiUsername", "apiPassword", "username");
```

### Table of contents

| Name        | Related to                                    |
| :---------- | :-------------------------------------------- |
| apiUsername | Your api username                             |
| apiPassword | Your api password                             |
| username    | Account username you want to know the domains |

## Get user by domain

Get a user by a domain.

### Usage

```cs
//Get user by domain
Domains.GetUserByDomain("apiUsername", "apiPassword", "domain");
```

### Table of contents

| Name        | Related to                             |
| :---------- | :------------------------------------- |
| apiUsername | Your api username                      |
| apiPassword | Your api password                      |
| domain      | Domain from knowing the user           |
