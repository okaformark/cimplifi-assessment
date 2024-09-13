// See https://aka.ms/new-console-template for more information

using cimplifi_exception;

AgeValidation ag = new AgeValidation();

Application app = new Application(ag);

app.ValidateAge(35);
app.ValidateAge(-1);

