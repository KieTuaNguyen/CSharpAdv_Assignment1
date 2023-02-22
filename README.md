# CSharpAdv_Assignment2 - Factory Pattern section

## In this project, the Factory pattern has been applied in the following classes:

## CourseFactory: The CreateCourse method in the CourseFactory class creates an instance of Course class based on the string type passed as a parameter. This method returns an ICourse interface which is implemented by the Course class.

## PersonFactory: The CreatePerson method in the PersonFactory class creates an instance of the Student class based on the string type passed as a parameter. This method returns an IPerson interface which is implemented by the Student class.

## Both the CourseFactory and PersonFactory classes have a static factory method that returns an interface. The factory method takes a string parameter that specifies the type of object to be created. Based on the type specified, the factory method creates an instance of the appropriate class and returns it as an interface.