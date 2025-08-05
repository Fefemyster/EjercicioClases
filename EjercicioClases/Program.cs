using EjercicioClases;

Persona persona = new Persona();
persona.Nombre = "Vera";
persona.Apellido = "Geiravor";
persona.Edad = 17;
persona.Saludar();

Persona persona1 = new Persona();
persona1.Nombre = "Carlotta";
persona1.Apellido = "Montelli";
persona1.Edad = 23;
persona1.Saludar();

Persona persona2 = new Persona();
persona2.Nombre = "Qu";
persona2.Apellido = "Shukra";
persona2.Edad = 18;
persona2.Saludar();



Libro libro = new Libro();
libro.Titulo = "Nier";
libro.Autor = "Square Enix";
libro.AñoPublicacion = 2024;

libro.MostrarInformacion();

Libro libro1 = new Libro();
libro1.Titulo = "Nier2";
libro1.Autor = "Square Enix2";
libro1.AñoPublicacion = 2025;

libro1.MostrarInformacion();

Libro libro2= new Libro();
libro2.Titulo = "Nier3";
libro2.Autor = "Square Enix3";
libro2.AñoPublicacion = 2026;

libro2.MostrarInformacion();

Estante estante = new Estante();
estante.NumeroEstante = 1;
estante.CapacidadMaxima = 3;
estante.LibrosEnEstante = new List<Libro> { libro, libro1,libro2 };
estante.MostrarContenido();





