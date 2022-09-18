using MapsterPlayground;
using MapsterPlayground.Contracts;

var user = UserGenerator.GenerateRandom();

var userResponse = new UserResponse(
    user.Id,
    user.FirstName,
    user.LastName
);

Console.WriteLine(user);
Console.WriteLine(userResponse);
