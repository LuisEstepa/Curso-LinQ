﻿using System;

LinqQueries queries = new LinqQueries();

//ImprimirValores(queries.TodaLaColeccion()); // mostrar toda la coleccion

//ImprimirValores(queries.LibrosDespuesdel2000()); // libros publicados despues del año 2000

//Console.WriteLine($"Todos los libros tienen estado? {queries.TodosLibrosTienenStatus()}");

//ImprimirValores(queries.LibrosDePython());

// ImprimirValores(queries.LibrosDeJavaPorNombreAscendente());

//ImprimirValores(queries.LibrosTerceroConMasDe400Paginas());

//ImprimirValores(queries.LibrosEntre200And400pag());

//Console.WriteLine($"La cantidad de Libros entre 200 y 400 paginas es: {queries.LibrosEntre200And400pag()}");

//Console.WriteLine($"Libro con la fecha de publicacion mas antigua es: {queries.LibrosMasAntigua()}");

//Console.WriteLine($"Libro con la fecha de publicacion mas reciente es: {queries.LibrosMasReciente()}");

// var libroMenorPag = queries.LibroConMenorNumeroDePaginas();
// Console.WriteLine($"El titulo {libroMenorPag.Title} con {libroMenorPag.PageCount} pagigas");

//Console.WriteLine(queries.TitulosDeLibrosDespuesDe2015Concatenados());//

//Console.WriteLine(queries.PromedioCaracteresTitulos());//

//ImprimirGrupo(queries.LibrosPublicadosDespuesDel2000());

// var lookup = queries.BuscarLibrosPorLetraInicial();

// ImprimirDiccionario(lookup,'C');

ImprimirValores(queries.LibrosMs500PagPublicadosDespuesDel2005)


void ImprimirDiccionario(ILookup<char, Book> ListadeLibros, char letra)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach(var item in ListadeLibros[letra])
    {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
    }
}

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach(var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

void ImprimirGrupo(IEnumerable<IGrouping<int,Book>> ListadeLibros)
{
    foreach(var grupo in ListadeLibros)
    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: { grupo.Key }");
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach(var item in grupo)
        {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
        }
    }
}