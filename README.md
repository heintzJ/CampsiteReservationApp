# CampsiteReservationApp
A web app created with .NET meant to emulate a service for people to reserve campsites

Uses the Model-View-Controller pattern, which decouples the user interface with the data and application logic. When a user makes a request, such as clicking a link, a controller retrieves required data from a model and sends the information to a view, displaying the information for the user.

When a user tries to log in, the data is sent to the Login method in the LoginPageController. The function validates the user's data with what is already stored in the database by getting the stored data through the LoginViewModel. If the credentials match, claims and authorization properties are created for the user to allow access to the CampgroundList View Model. Authentication is provided through cookies stored in the user's browser and allows access to views protected by the `[Authorize]` attribute.

When a new user is created, the data from the user is added to the database through the User model. The UsersController passes data from the Create form to the User model and hashes the password. The User model stores the data in the database with `_context.Add(user)` and the user is redirected to the login page.
