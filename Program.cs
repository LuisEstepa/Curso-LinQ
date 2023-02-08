
LinqQueries queries = new LinqQueries();

//ImprimirValores(queries.TodaLaColeccion()); // mostrar toda la coleccion

//ImprimirValores(queries.LibrosDespuesdel2000()); // libros publicados despues del año 2000

//Console.WriteLine($"Todos los libros tienen estado? {queries.TodosLibrosTienenStatus()}");

//ImprimirValores(queries.LibrosDePython());

// ImprimirValores(queries.LibrosDeJavaPorNombreAscendente());

//ImprimirValores(queries.LibrosTerceroConMasDe400Paginas());

//ImprimirValores(queries.LibrosEntre200And400pag());

Console.WriteLine($"La cantidad de Libros entre 200 y 400 paginas es: {queries.LibrosEntre200And400pag()}");

//Console.WriteLine($"Libro con la fecha de publicacion mas antigua es: {queries.LibrosMasAntigua()}");

//Console.WriteLine($"Libro con la fecha de publicacion mas reciente es: {queries.LibrosMasReciente()}");

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach(var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}
