# ClassLibraryStructure

	=========How to Creating the Project.=============#
- First Create a Employee_Recored Table in sqlserver.
- Create a new project. in this first create a empty solution. after, create a Class Library(.net Framwork) for data access. after that,
  Create a class Library(.net Framwork) for BusinessObjects. after that, create a webapi project for api.
- inserte the ADO.Net Entity Data Model in data access class library.
- Create a Employee Class in BusinessObjects class library.
- Create a IRepository for Crud operation  in BusinessObjects Class library.
- Give references to all the projects.
- After than, Create a new Controller for Api in api project.
- after than, set the  interface connection in controller.
- after that, set the all action in method.
	