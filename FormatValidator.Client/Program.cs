using FormatValidator.String;

IValidator validator = new AngleBracketValidator();
Console.WriteLine("'<>' :" + validator.Validate("<>"));
Console.WriteLine("'><' :" + validator.Validate("><"));
Console.WriteLine("'<<>' :"+ validator.Validate("<<>"));
Console.WriteLine("'' :"+ validator.Validate(""));
Console.WriteLine("'<abc...xyz>' :"+ validator.Validate("<abc...xyz>"));


