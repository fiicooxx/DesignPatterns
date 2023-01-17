using Chain_of_responsibility;

var requestContext = new RequestContext()
{
    request = new Request()
    {
        EntityId = 101,
        UserId = 13,
        UserRole = "Admin"
    },
    respone = new Respone()
};

// Chain of 3 elements authorization => validation => response
var resultHandler = new ResultHandler(null);
var validationHandler = new ValidationHandler(resultHandler);
var authorizationHandler = new AuthorizationHandler(validationHandler);

authorizationHandler.Handle(requestContext);
Console.WriteLine($"IsSuccessful: {requestContext.respone.IsSuccess}\n" +
    $"Message: {requestContext.respone.Message}\n" +
    $"Data: {requestContext.respone.Data}");