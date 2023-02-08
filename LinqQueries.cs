public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();

    public LinqQueries()
    {
        using(StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() {PropertyNameCaseInsensitive = true});
        }
    }

    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }
    
    /*Utilizando el operdor where*///////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public IEnumerable<Book> LibrosDespuesdel2000()
    {   
        // query extension method
        //return librosCollection.Where(p=> p.PublishedDate.Year > 2000);

        // query expresion method
        return from  l in librosCollection where l.PublishedDate.Year > 2000 select l; // puedo pedir que muestre solo los campos "l.campo"
    }

    public IEnumerable<Book> LibrosRetoDos()
    {   
        // query extension method
        //return librosCollection.Where(p=> p.PageCount > 250 && p.Title.Contains("in Action")); // Contains es similar al like de SQL

        // query expresion method
        return from  l in librosCollection where l.PageCount > 2500 && l.Title.Contains("in Action") select l; // puedo pedir que muestre solo los campos "l.campo"
    }

    /*Utilizando el operador All y Any*//////////////////////////////////////////////////////////////////////////////////////////////////////////
    public bool TodosLibrosTienenStatus()
    {   
        // query extension method
        return librosCollection.All(p=> p.Status != string.Empty); // devuelve valor Booleano

        // query expresion method
        //return from  l in librosCollection where l.PageCount > 2500 && l.Title.Contains("in Action") select l; // puedo pedir que muestre solo los campos "l.campo"
    }
    public bool AlgunLibrosFuePublicadoEn2005()
    {   
        // query extension method
        return librosCollection.Any(p=> p.PublishedDate.Year == 2005);

        // query expresion method
        //return from  l in librosCollection where l.PageCount > 2500 && l.Title.Contains("in Action") select l; // puedo pedir que muestre solo los campos "l.campo"
    }

    /*Utilizando el operador Contains*//////////////////////////////////////////////////////////////////////////////////////////////////////////

    public IEnumerable<Book> LibrosDePython()
    {
        // query extension method
        return librosCollection.Where(p=> p.Categories.Contains("Python"));// parecido al like

        // query expresion method


    }
    
    /*Utilizando el operador OrderBy *//////////////////////////////////////////////////////////////////////////////////////////////////////////
        public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
    {
        // query extension method
        return librosCollection.Where(p=> p.Categories.Contains("Java")).OrderBy(p=> p.Title);// elementos que contienen Java en orden Ascendiente

        // query expresion method


    }
        /*Utilizando el operador OrderByDescending*//////////////////////////////////////////////////////////////////////////////////////
        public IEnumerable<Book> LibrosConMasDe450Paginas()
    {
        // query extension method
        return librosCollection.Where(p=> p.PageCount > 450).OrderByDescending(p=> p.PageCount);// elementos que contienen Java en orden Descendiente

        // query expresion method


    }
    /*Utilizando el operador Take *//////////////////////////////////////////////////////////////////////////////////////////////////////////
        public IEnumerable<Book> LibrosDeJavaTresMasNuevos()
    {
        // query extension method
        return librosCollection.Where(p=> p.Categories.Contains("Java")).OrderByDescending(p=> p.PublishedDate).Take(3);// tres elemendos que contienen Java publicados mas recientemente

        // query expresion method


    }

    /*Utilizando el operador Skip*//////////////////////////////////////////////////////////////////////////////////////
        public IEnumerable<Book> LibrosTerceroConMasDe400Paginas()
    {
        // query extension method
        return librosCollection.Where(p=> p.PageCount > 400)
        .Take(4)//trae la cantidad de registros que ñe indiquemos
        .Skip(2);// omite la cantidad de registros que le indiquenos

        // query expresion method


    }

      /*Utilizando el operador Select*//////////////////////////////////////////////////////////////////////////////////////
        public IEnumerable<Book> LibrosTresprimeros()
    {
        // query extension method
        return librosCollection.Take(3)//trae la cantidad de registros que le indiquemos
        .Select(p=> new Book(){Title = p.Title, PageCount = p.PageCount});// crea un nuevo arreglo con los campos que le indiquemos

        // query expresion method


    }

    /*Utilizando el operador Count *//////////////////////////////////////////////////////////////////////////////////////
    public int LibrosEntre200And400pag()
    {
        // query extension method
        return librosCollection.Count(p => p.PageCount >= 200 && p.PageCount <= 400);//cuenta y devuelve cantidad de libros entre 200 y 400 paginas
        

        // query expresion method


    }

    /*Utilizando el operador LongCount *//////////////////////////////////////////////////////////////////////////////////////
    public long LibrosEntre200And400pagLong()
    {
        // query extension method
        return librosCollection.LongCount(p => p.PageCount >= 200 && p.PageCount <= 400);//cuenta y devuelve cantidad de libros entre 200 y 400 paginas numeros mas grandes
        

        // query expresion method


    }

    /*Utilizando el operador Min *//////////////////////////////////////////////////////////////////////////////////////
    public DateTime LibrosMasAntigua()
    {
        // query extension method
        return librosCollection.Min(p => p.PublishedDate);//trae la fecha del libro publicacion mas antigua
        

        // query expresion method


    }
    
    /*Utilizando el operador Max *///////////////////////////////////////////////////////////////////////////////////////
    public DateTime LibrosMasReciente()
    {
        // query extension method
        return librosCollection.Max(p => p.PublishedDate);//trae la fecha del libro publicado mas reciente
        

        // query expresion method


    }
}