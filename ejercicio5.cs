using System;

public class Ejercicio_5
{
	public static void Salida()
	{
		Console.Clear();

		int entrada, operacion = 0;
		string url = "";

		Console.Write("ingrese la cantidad de usuarios :");
		int.TryParse(Console.ReadLine(), out entrada);

		url = "https://randomuser.me/api/?results=" + entrada;


	


		System.Net.WebClient client = new System.Net.WebClient();
		string datos = client.DownloadString(url);


		Root respuesta = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(datos);

		string final = "";

		foreach (var item in respuesta.results)
        {
			Console.WriteLine(item.name.first);
			final = final + $@"




    <div class ='card m-auto mt-5' style='width: 18rem; '>
 <img src='{item.picture.large}' class='card - img - top' alt='...'>

        <div class='card-body'>
            <h5 class='card-title'>{item.name.first} {item.name.last} </h5>
            <p class ='card-text'>

     <li> genero : {item.gender}</li>
     <li> ciudad : {item.location.city}</li>
     <li> edad : {item.dob.age}</li>
     <li> gmail : {item.email}</li>
            </p>

        </div>
    </div>

";






        }

		final = $@"
<html>

<head>
    <title>ejercicio 5</title>
    <link href='https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css'
                      //rel='stylesheet'
        integrity = 'sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor' crossorigin = 'anonymous' >
</head>

<body b>



{final}
        


</body>

</html>
";

		System.IO.File.WriteAllText("NUEVO.html", final);


			Ejercicios.abrir("NUEVO.html");



	}
}



